using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OpenSourceEnity.Models.ContextDb;
using OpenSourceEnity.Models.ControllerEntitiesHelpers;
using OpenSourceEnity.Models.ControllerEntitiesHelpers.ListUserControllerHelpers;
using OpenSourceEnity.Models.Entities.AggreagateLogEntities.IUnitOfWork;
using OpenSourceEnity.Models.Entities.SystemEntities;
using OpenSourceEnity.Models.ModelViews.EntityViews;
using static OpenSourceEnity.Models.ControllerEntitiesHelpers.ListUserControllerHelpers.Sorting;
using static OpenSourceEnity.Models.Entities.AggreagateLogEntities.Entities.LoggingEnum;

namespace OpenSourceEnity.Controllers
{
    [Authorize]
    public class ListUserController : Controller
    {
        private ApplicationEnityContextdb contextdb { get; set; }
        private SignInManager<User> SignInManager { get; set; }
        private IUnitLogOfWork UnitLogOfWork { get; set; }

        public ListUserController(
            ApplicationEnityContextdb contextdb,
            SignInManager<User> SignInManager,
            IUnitLogOfWork UnitLogOfWork
            )
        {
            this.contextdb = contextdb;
            this.SignInManager = SignInManager;
            this.UnitLogOfWork = UnitLogOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> Index(string UserId, string MiddleName, string Name, string LastName , Sort sorting = Sort.LastNameAsc, int page = 1)
        {
            var list = await contextdb.Participants.Include(t => t.User).ToListAsync();

            ListUserFiltering listUserFiltering = new ListUserFiltering(list);

            var resultListFiltering = listUserFiltering.ParticipantsFilter(MiddleName, Name, LastName);

            ListParticiapntSorting listParticiapntSorting = new ListParticiapntSorting(sorting);

            var resultlistSorting = listParticiapntSorting.ParticipantsSorting(resultListFiltering, sorting);

            ListUserPagination listUserPagination = new ListUserPagination(page, 5, 5);

            await UnitLogOfWork.RepositoryLogging.InsertLog(UserId, InformationLoggingEnum.ListUser);

            return View(new ListUser
            {
                Participants = resultListFiltering.Skip((page - 1) * 5).Take(5),
                ListUserPagination = listUserPagination,
                listParticiapntSorting = listParticiapntSorting,
                listUserFiltering = listUserFiltering,
                UserId = UserId
            }); 
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await SignInManager.SignOutAsync();

            return RedirectToAction("Index", "Front");
        }
    }
}