using Microsoft.AspNetCore.Identity;
using OpenSourceEnity.Models.Entities.EntityController.ExtensionAgeMethods;
using OpenSourceEnity.Models.Entities.SystemEntities;
using OpenSourceEnity.Models.ModelViews.EntityViews;
using OpenSourceEnity.Models.Entities.EntityController.ClaimsService;
using System;
using System.Threading.Tasks;

namespace OpenSourceEnity.Models.Entities.EntityController.UserService
{
    //<summary>
    //Класс сервис отвечающий за обработку пользователя
    //</summary>
    public class UserService
    {
        private UserManager<User> UserManager { get; set; }

        //<summary>
        //Конструктор предоставляющий инициализацию параметров: 
        ///<param name="UserManager">Свой предоставляющее доступ по работе с пользователями.</param>
        //</summary>
        public UserService(UserManager<User> UserManager)
        {
            this.UserManager = UserManager;
        }

        //<summary>
        //Метод отвечающий за формирование пользователя
        ///<param name="registration">Ссылка на форму регистрации</param>
        //</summary>
        public User GetUserMapper(Registration Registration)
        {
            if (Registration.Email == null || Registration.UserName == null || Registration.DomensId == null)
                throw new ArgumentNullException("Error null Email and UserName");


            return new User
            {
                Email = Registration.Email,
                UserName = Registration.UserName,
                Age = Registration.DateAge.UserAge(),
                DateChanges = DateTime.Now.ToString(),
                DateCreate = DateTime.Now.ToString(),
                DomainId = Registration.DomensId
            };

        }

        //<summary>
        //Метод отвечающий за получения пользователя по почты
        ///<param name="Email">Email пользователя</param>
        //</summary>
        public async Task<User> GetUserAsync(string Email)
        {
            var result = await UserManager.FindByEmailAsync(Email);

            return result;
        }

        //<summary>
        //Метод отвечающий за создание пользователя
        ///<param name="user">Ссылка на пользователя</param>
        ///<param name="password">Пароль пользователя</param>
        //</summary>
        public async Task<IdentityResult> UserCreate(User user, string password)
        {
            return await UserManager.CreateAsync(user, password);
        }

    }
}
