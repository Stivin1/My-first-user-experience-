using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OpenSourceEnity.Models.Entities.AggreagateLogEntities.IUnitOfWork;
using OpenSourceEnity.Models.Entities.SystemEntities;
using OpenSourceEnity.Models.ModelViews.EntityViews;
using static OpenSourceEnity.Models.Entities.AggreagateLogEntities.Entities.LoggingEnum;

namespace OpenSourceEnity.Controllers
{
    [Authorize]
    public class RoleController : Controller
    {
        private UserManager<User> UserManager { get; set; }
        private RoleManager<IdentityRole> RoleManager { get; set; }
        private IUnitLogOfWork UnitLogOfWork { get; set; }

        public RoleController(
            UserManager<User> UserManager,
            RoleManager<IdentityRole> RoleManager,
            IUnitLogOfWork UnitLogOfWork
            )
        {
            this.UserManager = UserManager;
            this.RoleManager = RoleManager;
            this.UnitLogOfWork = UnitLogOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> RoleCreate(string UserId)
        {
            await UnitLogOfWork.RepositoryLogging.InsertLog(UserId, InformationLoggingEnum.RoleViewAppend);

            return View(new RoleCreate { UserId = UserId } );
        }

        [HttpPost]
        public async Task<IActionResult> RoleCreate(string UserId, string RoleName)
        {
            if(ModelState.IsValid)
            {
                var resultsear = await RoleManager.FindByNameAsync(RoleName);

                if (resultsear == null)
                {
                    await UnitLogOfWork.RepositoryLogging.InsertLog(UserId, InformationLoggingEnum.RoleAppend);

                    IdentityResult result = await RoleManager.CreateAsync(new IdentityRole(RoleName));

                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Role", new { UserId });
                    }
                    else
                    {
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError(string.Empty, error.Description);
                        }
                    }
                }
            }

            return View(new RoleCreate { UserId = UserId });
        }

        [HttpGet]
        public async Task<IActionResult> RoleAppendUser(string UserId)
        {
            var resultUser = await UserManager.FindByIdAsync(UserId);

            if (ModelState.IsValid) 
            {
                if (resultUser != null)
                {
                    await UnitLogOfWork.RepositoryLogging.InsertLog(UserId, InformationLoggingEnum.RoleViewUserAppend);

                    var resultRoleUser = await UserManager.GetRolesAsync(resultUser);
                    var resultRole = await  RoleManager.Roles.ToListAsync();

                    return View(new RoleAppendUser
                    {
                        UserId = UserId,
                        UserName = resultUser.UserName,
                        Email = resultUser.Email,
                        RoleName = resultRoleUser,
                        IdentityRoles = resultRole
                    });
                }
                else
                {
                    return NotFound();
                }
            }

            return View(new RoleAppendUser { UserId = UserId });
        }

        [HttpPost]
        public async Task<IActionResult> RoleAppendUser(string UserId, List<string> Roles)
        {
            var resultUser = await UserManager.FindByIdAsync(UserId);

            if (resultUser != null)
            {
                if (ModelState.IsValid)
                {
                    await UnitLogOfWork.RepositoryLogging.InsertLog(UserId, InformationLoggingEnum.RoleUserAppend);

                    var resultRoleUser = await UserManager.GetRolesAsync(resultUser);

                    var addRole = Roles.Except(resultRoleUser);

                    var removeRole = resultRoleUser.Except(Roles);

                    await UserManager.AddToRolesAsync(resultUser, addRole);

                    await UserManager.RemoveFromRolesAsync(resultUser, removeRole);

                    return RedirectToAction("RoleAppendUser", new { UserId });

                }
            }

            return NotFound();
        }

    }
}