using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OpenSourceEnity.Models.ContextDb;
using OpenSourceEnity.Models.Entities.AggreagateLogEntities.IUnitOfWork;
using OpenSourceEnity.Models.Entities.AggregateEntities.IRepository;
using OpenSourceEnity.Models.Entities.SystemEntities;
using OpenSourceEnity.Models.ModelViews.EntityViews;
using static OpenSourceEnity.Models.Entities.AggreagateLogEntities.Entities.LoggingEnum;

namespace OpenSourceEnity.Controllers
{
    [Authorize]
    public class TeamController : Controller
    {
        public UserManager<User> UserManager { get; set; }
        private IUnitOfWork UnitOfWork { get; set; }
        public ApplicationEnityContextdb EnityContextdb { get; set; }
        private IUnitLogOfWork UnitLogOfWork { get; set; }

        public TeamController(
            UserManager<User> UserManager,
            IUnitOfWork UnitOfWork,
            ApplicationEnityContextdb EnityContextdb,
            IUnitLogOfWork UnitLogOfWork
            )
        {
            this.UserManager = UserManager;
            this.UnitOfWork = UnitOfWork;
            this.EnityContextdb = EnityContextdb;
            this.UnitLogOfWork = UnitLogOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> TeamCreate(string UserId)
        {
            await UnitLogOfWork.RepositoryLogging.InsertLog(UserId, InformationLoggingEnum.TeamViewAppend);

            return View(new TeamCreate { UserId = UserId });
        }

        [HttpPost]
        public async Task<IActionResult> TeamCreate(TeamCreate TeamCreate)
        {
            if(ModelState.IsValid)
            {
                if (TeamCreate.UserId != null)
                {
                    await UnitLogOfWork.RepositoryLogging.InsertLog(TeamCreate.UserId, InformationLoggingEnum.TeamAppend);

                    var result = await EnityContextdb.Teams.FirstOrDefaultAsync(t => t.Name == TeamCreate.Name);

                    if (result == null)
                    {
                        result = new Team
                        {
                            Name = TeamCreate.Name
                        };

                        await UnitOfWork.RepositoryTeam.Create(result);
                    }
                }
                else
                {
                    return NotFound();
                }
            }

            return View(new TeamCreate { UserId = TeamCreate.UserId});
        }

        [HttpGet]
        public async Task<IActionResult> TeamUserCreate(string UserId)
        {
            
            if (UserId != null)
            {
                await UnitLogOfWork.RepositoryLogging.InsertLog(UserId, InformationLoggingEnum.TeamViewUserAppned);

                var teams = await UnitOfWork.RepositoryTeam.GetEntitys();

                var user = await UserManager.FindByIdAsync(UserId);
                var result = await UnitOfWork.RepositoryTeam.GetEntitys(user.Id);

                return View(new TeamUser
                {
                    UserId = UserId,
                    UserName = user.UserName,
                    IdentityTeams = teams,
                    TeamsUser = result
                });
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> TeamUserCreate(string UserId, string[] Tems)
        {
            if(UserId != null)
            {
                await UnitLogOfWork.RepositoryLogging.InsertLog(UserId, InformationLoggingEnum.TeamUserAppned);

                var user = await UserManager.FindByIdAsync(UserId);
                var result = await UnitOfWork.RepositoryTeam.GetEntitys(user.Id);

                var addtems = Tems.Except(result);
                var remove = result.Except(Tems);

                await UnitOfWork.RepositoryTeam.AddTeamsEntitys(user, addtems);
                await UnitOfWork.RepositoryTeam.RemoveTeamsEntitys(user, remove);

                return RedirectToAction("TeamUserCreate","Team", new { UserId });

            }

            return NotFound();
        }
    }
}