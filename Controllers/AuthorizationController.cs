using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OpenSourceEnity.Logger.LoggerAuthorization;
using OpenSourceEnity.Models.Entities.AggreagateLogEntities.IUnitOfWork;
using OpenSourceEnity.Models.Entities.SystemEntities;
using OpenSourceEnity.Models.ModelViews.EntityViews;
using static OpenSourceEnity.Models.Entities.AggreagateLogEntities.Entities.LoggingEnum;

namespace OpenSourceEnity.Controllers
{
    public class AuthorizationController : Controller
    {
        private IWebHostEnvironment Environment { get; set; }
        private UserManager<User> UserManager { get; set; }
        private SignInManager<User> SignInManager { get; set; }
        private IUnitLogOfWork UnitLogOfWork { get; set; }
        private ILogger<AuthorizationController> logger { get; set; }

        public AuthorizationController(
            UserManager<User> UserManager,
            SignInManager<User> SignInManager,
            IUnitLogOfWork UnitLogOfWork,
            ILogger<AuthorizationController> logger,
            IWebHostEnvironment Environment
            )
        {
            this.UserManager = UserManager;
            this.SignInManager = SignInManager;
            this.UnitLogOfWork = UnitLogOfWork;
            this.logger = logger;
            this.Environment = Environment;
        }

        [HttpGet]
        public IActionResult Index(string Url = null)
        {
            return View(new Authorization { UrlLink = Url });
        }

        [HttpPost]
        public async Task<IActionResult> Index(Authorization authorization)
        {
            if(ModelState.IsValid)
            {
                var result = await SignInManager.PasswordSignInAsync(authorization.Email, authorization.Password, true,false);

                var user = await UserManager.FindByEmailAsync(authorization.Email);

                try
                {
                    if (result.Succeeded)
                    {
                        await UnitLogOfWork.RepositoryLogging.InsertLog(user.Id, InformationLoggingEnum.AttemptHome);

                        EventLogsAuthorization.EventRequestInfo(logger, Environment, user);

                        if (!string.IsNullOrEmpty(authorization.UrlLink) && Url.IsLocalUrl(authorization.UrlLink))
                        {
                            return Redirect(authorization.UrlLink);
                        }
                        else
                        {
                            return RedirectToAction("Index", "Home");
                        }
                    }
                }
                catch(Exception exc)
                {
                    EventLogsAuthorization.EventRequestErrorInfo(logger, Environment,user, exc);
                }
            }

            return View(authorization);
        }
    }
}