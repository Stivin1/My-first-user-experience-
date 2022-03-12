using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OpenSourceEnity.Models;
using OpenSourceEnity.Models.Entities.SystemEntities;
using OpenSourceEnity.Models.ModelViews.EntityViews;

namespace OpenSourceEnity.Controllers
{
    public class FrontController : Controller
    {
        public UserManager<User> UserManager { get; set; }
        private readonly ILogger<FrontController> _logger;

        public FrontController(
            ILogger<FrontController> logger, 
            UserManager<User> UserManager
            )
        {
            _logger = logger;

            this.UserManager = UserManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new Front { Count = UserManager.Users.Count() });
        }

        [HttpPost]
        public async Task<IActionResult> Index(Front front)
        {
            if(ModelState.IsValid)
            {
                User user = await UserManager.FindByEmailAsync(front.Email);

                if(user == null)
                {
                    return RedirectToAction("Index", "Registration", new { FrontEmail = front.Email }  );
                }
                else
                {
                    ModelState.AddModelError("Email", "Электронная почта уже зарегистрирована");
                }
            }

            return View(front);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
