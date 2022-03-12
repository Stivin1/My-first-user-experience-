using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace OpenSourceEnity.Models.ModelViews.EntityViews
{
    //<summary>
    //Модель отвечающая за добавление роли пользователю
    //</summary>
    public class RoleAppendUser
    {
        //<summary>
        //Поле предоставляющий идентификатор пользователя
        //</summary>
        public string UserId { get; set; }

        //<summary>
        //Поле предоставляющее почту пользователя
        //</summary>
        public string Email { get; set; }

        //<summary>
        //Поле предоставляющее имя пользователя
        //</summary>
        public string UserName { get; set; }

        //<summary>
        //Список ролей
        //</summary>
        public IList<string> RoleName { get; set; }

        //<summary>
        //Список системных ролей
        //</summary>
        public List<IdentityRole> IdentityRoles { get; set; }

        //<summary>
        //Класс инициализации свойств коллекций 
        //</summary>
        public RoleAppendUser()
        {
            RoleName  = new List<string>();
            IdentityRoles  = new List<IdentityRole>();
        }
    }
}
