using Microsoft.AspNetCore.Identity;
using OpenSourceEnity.Models.Entities.SystemEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace OpenSourceEnity.Models.Entities.EntityController.ClaimsService
{
    public class ClaimService
    {
        private UserManager<User> UserManager { get; set; }

        //<summary>
        //Конструктор предоставляющий инициализацию параметров: 
        ///<param name="UserManager">Свой предоставляющее доступ по работе с пользователями.</param>
        //</summary>
        public ClaimService(UserManager<User> UserManager)
        {
            this.UserManager = UserManager;
        }

        public async Task AddClaimUser(User user,string area)
        {
            var past = new List<Claim>
            {
                new Claim("Default", "User"),
                new Claim("Areas", area)
            };

            await UserManager.AddClaimsAsync(user, past);
        }
    }
}
