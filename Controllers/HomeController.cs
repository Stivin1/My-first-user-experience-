using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using OpenSourceEnity.Logger.LoggerAuthorization;
using OpenSourceEnity.Logger.LoggerHome;
using OpenSourceEnity.Models.ContextDb;
using OpenSourceEnity.Models.ControllerEntitiesHelpers.MessageService;
using OpenSourceEnity.Models.Entities.AggreagateLogEntities.IUnitOfWork;
using OpenSourceEnity.Models.Entities.AggregateEntities.IRepository;
using OpenSourceEnity.Models.Entities.EntityController.ExtensionAgeMethods;
using OpenSourceEnity.Models.Entities.EntityController.ParticipantService;
using OpenSourceEnity.Models.Entities.SystemEntities;
using OpenSourceEnity.Models.ModelViews.EntityViews;
using OpenSourceEnity.Models.Service.ServiceSession;
using System;
using System.Threading.Tasks;
using static OpenSourceEnity.Models.Entities.AggreagateLogEntities.Entities.LoggingEnum;

namespace OpenSourceEnity.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private IUnitOfWork UnitOfWork { get; set; }
        private IUnitLogOfWork UnitLogOfWork { get; set; }
        private ApplicationEnityContextdb contextdb { get; set; }
        private UserManager<User> UserManager { get; set; }
        private SignInManager<User> SignInManager { get; set; }
        private MessagingService MessagingService { get; set; }
        private ParticipantService ParticipantService { get; set; }
        private ILogger<HomeController> Logger { get; set; }
        private IWebHostEnvironment Environment { get; set; }

        public HomeController(
            ApplicationEnityContextdb contextdb,
            IUnitLogOfWork UnitLogOfWork,
            UserManager<User> UserManager,
            IUnitOfWork UnitOfWork,
            SignInManager<User> SignInManager,
            ParticipantService ParticipantService,
            ILogger<HomeController> Logger,
            IWebHostEnvironment Environment
            )
        {
            this.contextdb = contextdb;
            this.UserManager = UserManager;
            this.UnitOfWork = UnitOfWork;
            this.UnitLogOfWork = UnitLogOfWork;
            this.SignInManager = SignInManager;
            this.ParticipantService = ParticipantService;
            this.Logger = Logger;
            this.Environment = Environment;

            MessagingService = new MessagingService(contextdb);
        }

        [HttpGet]
        [Authorize(Policy = "User")]
        [Authorize(Policy = "Area")]
        public async Task<IActionResult> Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                var search = await contextdb.Users
                   .Include(t => t.Participant)
                   .ThenInclude(t => t.Country)
                   .Include(t => t.Participant)
                   .ThenInclude(t => t.Pol)
                   .FirstOrDefaultAsync(s => s.UserName == User.Identity.Name);

                try
                {

                    if (search == null) throw new ArgumentNullException();

                    HttpContext.Session.Set(".AspApplicationUser.A009S230S12E", new User { Id = search.Id });

                    EventLogsHome.EventRequestInfo(Logger, Environment, search);

                    await UnitLogOfWork.RepositoryLogging.InsertLog(search.Id, InformationLoggingEnum.ViewingHome);

                    return View(new Home
                    {
                        User = search,
                        Participant = search.Participant,
                        Country = search.Participant.Country,
                        Pol = search.Participant.Pol,
                    });
                }
                catch(ArgumentNullException ex)
                {
                    EventLogsHome.EventRequestErrorInfo(Logger, Environment,search, ex);
                }

            }

            return Unauthorized();
        }

        [HttpGet]
        public async Task<IActionResult> UpdateParticipant(string UserId)
        {
            if (UserId != null)
            {
                await UnitLogOfWork.RepositoryLogging.InsertLog(UserId, InformationLoggingEnum.HomeViewParticipantUpdate);

                return View(new UpdateParticipant
                {
                    UserId = UserId,
                    Participant = await contextdb.Participants.FirstOrDefaultAsync(t => t.UserId == UserId),
                    SelectListCountryItems = new SelectList(await UnitOfWork.RepositoryCountry.GetEntitys(), "id", "Name"),
                    SelectListPolItems = new SelectList(await UnitOfWork.RepositoryPol.GetEntitys(), "id", "Name")
                });
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> UpdateParticipant(UpdateParticipant updateParticipant)
        {
            if (ModelState.IsValid)
            {
                if (updateParticipant.UserId != null)
                {
                    await UnitLogOfWork.RepositoryLogging.InsertLog(updateParticipant.UserId, InformationLoggingEnum.HomeParticipantUpdate);

                    await ParticipantService.GetUpdateParticipant(updateParticipant);
                }
            }

            return RedirectToAction("UpdateParticipant", new  {
                updateParticipant.UserId,
                SelectListCountryItems = new SelectList(await UnitOfWork.RepositoryCountry.GetEntitys(), "id", "Name"),
                SelectListPolItems = new SelectList(await UnitOfWork.RepositoryPol.GetEntitys(), "id", "Name")
            } );
        }

        [HttpGet]
        public async Task<IActionResult> UserUpdate(string UserId)
        {
            if (UserId != null)
            {
                await UnitLogOfWork.RepositoryLogging.InsertLog(UserId, InformationLoggingEnum.HomeViewUserApdate);

                User user = await UserManager.FindByIdAsync(UserId);

                return View(new UserUpdate
                {
                    UserId = UserId,
                    UserName = user.Email
                });
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> UserUpdate(UserUpdate userUpdate)
        {
            User user = await UserManager.FindByIdAsync(userUpdate.UserId);

            if (ModelState.IsValid)
            {
                 if (user != null)
                 {
                     await UnitLogOfWork.RepositoryLogging.InsertLog(userUpdate.UserId, InformationLoggingEnum.HomeUserApdate);

                     await UserManager.ChangePasswordAsync(user, userUpdate.OldPassword, userUpdate.NewPassword);

                     var user_message = await UserManager.FindByIdAsync(userUpdate.UserId);
                     await MessagingService.UpdateUserInformation(user_message);
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "User not found");
                }
            }

            return View(new UserUpdate { UserName = user.UserName, UserId = user.Id });
        }


        public async Task<IActionResult> Logout()
        {
            HttpContext.Response.Cookies.Delete(".AspApplicationUser.A009S230S12E");

            await SignInManager.SignOutAsync();

            return RedirectToAction("Index", "Front");
        }
    }
}