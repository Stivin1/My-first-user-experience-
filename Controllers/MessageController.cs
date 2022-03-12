using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OpenSourceEnity.Models.ContextDb;
using OpenSourceEnity.Models.ControllerEntitiesHelpers.ListReceivMessageControllerHelpers;
using OpenSourceEnity.Models.ControllerEntitiesHelpers.ListUserMessageControllerHelpers;
using OpenSourceEnity.Models.ControllerEntitiesHelpers.MessageService;
using OpenSourceEnity.Models.Entities.AggreagateLogEntities.IUnitOfWork;
using OpenSourceEnity.Models.Entities.AggregateEntities.IRepository;
using OpenSourceEnity.Models.Entities.SystemEntities;
using OpenSourceEnity.Models.ModelViews.EntityViews;
using static OpenSourceEnity.Models.ControllerEntitiesHelpers.ListReceivMessageControllerHelpers.Sorting;
using static OpenSourceEnity.Models.ControllerEntitiesHelpers.ListUserMessageControllerHelpers.Sorting;
using static OpenSourceEnity.Models.Entities.AggreagateLogEntities.Entities.LoggingEnum;

namespace OpenSourceEnity.Controllers
{
    public class MessageController : Controller
    {
        private ApplicationEnityContextdb contextdb { get; set; }
        private UserManager<User> UserManager { get; set; }
        private IUnitLogOfWork UnitLogOfWork { get; set; }
        private IUnitOfWork UnitOfWork { get; set; }
        private MessagingService MessagingService { get; set; }

        public MessageController(
            ApplicationEnityContextdb contextdb,
            IUnitLogOfWork UnitLogOfWork,
            IUnitOfWork UnitOfWork,
            UserManager<User> UserManager
            )
        {
            this.contextdb = contextdb;
            this.UnitLogOfWork = UnitLogOfWork;
            this.UserManager = UserManager;
            this.UnitOfWork = UnitOfWork;

            MessagingService = new MessagingService(contextdb);
        }

        [HttpGet]
        public async Task<IActionResult> UserListMessage(string UserId, string Email, string UserName, Sort sorting = Sort.EmailAsc, int page = 1)
        {
            var list = await contextdb.Users.Include(t => t.Participant).ToListAsync();

            ListUesrMessageFiltering listUserFiltering = new ListUesrMessageFiltering(list);

            var resultListFiltering = listUserFiltering.ParticipantsFilter(Email, UserName);

            ListUserMessageSorting listUserMessageSorting = new ListUserMessageSorting(sorting);

            var resultlistSorting = listUserMessageSorting.UserSorting(resultListFiltering, sorting);

            ListUserMessagePagination listUserPagination = new ListUserMessagePagination(page, 5, 5);

            await UnitLogOfWork.RepositoryLogging.InsertLog(UserId, InformationLoggingEnum.UserListMessageViewAppned);

            return View(new UserListMessage
            {
                Users = resultlistSorting.Skip((page - 1) * 5).Take(5),
                ListUserMessagePagination = listUserPagination,
                ListUserMessageSorting = listUserMessageSorting,
                ListUesrMessageFiltering = listUserFiltering,
                UserId = UserId
            });
        }

        [HttpGet]
        public async Task<IActionResult> UserMessage(string UserId, string UserIdRecipient)
        {
            if(!string.IsNullOrEmpty(UserId) && !string.IsNullOrEmpty(UserIdRecipient))
            {
                var user_sender = await UserManager.FindByIdAsync(UserId);
                var user_recipient = await UserManager.FindByIdAsync(UserIdRecipient);

                return View(new UserMessage
                {
                    UserId = UserId,
                    UserIdRecipient = UserIdRecipient,
                    UserName = user_sender.UserName,
                    UserNameRecipient = user_recipient.UserName
                }); 
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> UserMessage(UserMessage userMessage)
        {
            if (string.IsNullOrEmpty(userMessage.UserId) || string.IsNullOrEmpty(userMessage.UserIdRecipient)) return NotFound();

            var user_sender = await UserManager.FindByIdAsync(userMessage.UserId);
            var user_recipient = await UserManager.FindByIdAsync(userMessage.UserIdRecipient);

            if (ModelState.IsValid)
            {

                await MessagingService.SendMessageService(
                    userMessage.UserId, 
                    userMessage.UserIdRecipient, 
                    userMessage.Theme, 
                    userMessage.Text);

            }

            return View(new UserMessage
            {
                UserId = userMessage.UserId,
                UserIdRecipient = userMessage.UserIdRecipient,
                UserName = user_sender.UserName,
                UserNameRecipient = user_recipient.UserName
            });
        }

        [HttpGet]
        public async Task<IActionResult> ReceivingMessage(string UserId, string MiddleName, string Name, string LastName, ReceivSort sorting = ReceivSort.UserNameAsc, int page = 1)
        {
            var participants = MessagingService.ListReadingMessageService(UserId);

            ListReceivMessageFiltering listUserFiltering = new ListReceivMessageFiltering(participants);

            var resultListFiltering = listUserFiltering.ParticipantsFilter(MiddleName, Name, LastName);

            ListReceivMessageSorting listUserMessageSorting = new ListReceivMessageSorting(sorting);

            var resultlistSorting = listUserMessageSorting.ParticipantsSorting(resultListFiltering, sorting);

            ListReceivMessagePagination listUserPagination = new ListReceivMessagePagination(page, 15, resultlistSorting.Count());

            await UnitLogOfWork.RepositoryLogging.InsertLog(UserId, InformationLoggingEnum.ReceivingViewMessage);

            return View(new ReceivingMessage
            {
                AddresseeMessage = resultlistSorting.Skip((page - 1) * 8).Take(8).OrderByDescending(t => t.Message.DataCreate),
                ListReceivMessagePagination = listUserPagination,
                ListReceivMessageSorting = listUserMessageSorting,
                ListReceivMessageFiltering = listUserFiltering,
                UserId = UserId
            });
        }

        [HttpGet]
        public async Task<IActionResult> UserReadMessage(string UserId, int MessageId)
        {
            var message = await MessagingService.GetReadMessageAsync(MessageId);
            var recip = await UserManager.FindByIdAsync(message.RecipientId);
            var donor = await UserManager.FindByIdAsync(message.UserId);

            await UnitLogOfWork.RepositoryLogging.InsertLog(UserId, InformationLoggingEnum.ReceivingMessage);

            return View(new UserReadMessage
            {
                UserId = UserId,
                UserRecipientId = message.RecipientId,
                UserDonorName = donor.Email,
                UserRecipienName = recip.Email,
                Text = message.Message.Text
            });
        }
    }
}