using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OpenSourceEnity.Models.ContextDb;
using OpenSourceEnity.Models.ControllerEntitiesHelpers.MessageService;
using OpenSourceEnity.Models.Entities.AggregateEntities.IRepository;
using OpenSourceEnity.Models.Entities.EntityController.ClaimsService;
using OpenSourceEnity.Models.Entities.EntityController.ParticipantService;
using OpenSourceEnity.Models.Entities.EntityController.UserService;
using OpenSourceEnity.Models.Entities.SystemEntities;
using OpenSourceEnity.Models.ModelViews.EntityViews;

namespace OpenSourceEnity.Controllers
{
    public class RegistrationController : Controller
    {
        private ApplicationEnityContextdb EnityContextdb { get; set; }
        private IUnitOfWork UnitOfWork { get; set; }
        private UserService UserService { get; set; }
        private ParticipantService ParticipantService { get; set; }
        private UserManager<User> UserManager { get; set; }
        private MessagingService MessagingService { get; set; }
        private ClaimService ClaimService { get; set; }

        public RegistrationController(
            ApplicationEnityContextdb EnityContextdb,
            IUnitOfWork UnitOfWork,
            UserService UserService,
            ParticipantService ParticipantService,
            UserManager<User> UserManager,
            MessagingService MessagingService,
            ClaimService ClaimService
            )
        {
            this.EnityContextdb = EnityContextdb;
            this.UnitOfWork = UnitOfWork;
            this.UserService = UserService;
            this.ParticipantService = ParticipantService;
            this.UserManager = UserManager;
            this.MessagingService = MessagingService;
            this.ClaimService = ClaimService;
        }

        [HttpGet]
        public async Task<IActionResult> Index(string FrontEmail)
        {
            var country = await UnitOfWork.RepositoryCountry.GetEntitys();
            var pol = await UnitOfWork.RepositoryPol.GetEntitys();
            var domen = await UnitOfWork.RepositoryDomains.GetEntitys();

            return View(new Registration
            {
                Email = FrontEmail,
                SelectListCountryItems = new SelectList(country, "id", "Name"),
                SelectListPolItems = new SelectList(pol, "id", "Name"),
                SelectListDomensItems = new SelectList(domen, "Id", "Name")
            }) ; 
        }

        [HttpPost]
        public async Task<IActionResult> Index(Registration registration)
        {
            var country = await UnitOfWork.RepositoryCountry.GetEntitys();
            var pol = await UnitOfWork.RepositoryPol.GetEntitys();
            var domen = await UnitOfWork.RepositoryDomains.GetEntitys();

            var user_domain = EnityContextdb.Domens.FirstOrDefaultAsync(t => t.Id == registration.DomensId);

            if (registration.Email != null && !registration.Email.Contains(user_domain.Result.Name))
            {
                ModelState.AddModelError("Email", "Электронный адрес заполнен не корректно, выбирите правильный домен.");
            }

            if (ModelState.IsValid)
            {
                var search_user = await UserService.GetUserAsync(registration.Email);

                if (search_user == null)
                {
                    var user_builder = UserService.GetUserMapper(registration);
                    
                    if (user_builder != null)
                    {
                        var result = await UserService.UserCreate(user_builder, registration.Password);

                        if (result.Succeeded)
                        {                            
                            var part_builder = ParticipantService.GetParticipantMapper(registration, user_builder);
                            await UnitOfWork.RepositoryParticipant.Create(part_builder);

                            var user_record = await UserManager.FindByEmailAsync(registration.Email);

                            await ClaimService.AddClaimUser(user_record, part_builder.Country.Name);

                            await MessagingService.RegistrationInformation(user_record);

                            return RedirectToAction("SuccessfulRegistration", "Registration");
                        }
                    }
                }
            }

            return View(new Registration
            {
                SelectListCountryItems = new SelectList(country, "id", "Name"),
                SelectListPolItems = new SelectList(pol, "id", "Name"),
                SelectListDomensItems = new SelectList(domen, "Id", "Name")
            });
        }

        [HttpGet]
        public IActionResult SuccessfulRegistration()
        {
            return View();
        }
    }
}