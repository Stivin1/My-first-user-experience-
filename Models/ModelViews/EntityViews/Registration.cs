using Microsoft.AspNetCore.Mvc.Rendering;
using OpenSourceEnity.Models.ModelViews.EntityViewsAttributes.RegistrationAttributes;
using System.ComponentModel.DataAnnotations;

namespace OpenSourceEnity.Models.ModelViews.EntityViews
{
    //<summary>
    //Модель отвечающая за регистрацию пользователей
    //</summary>
    public class Registration
    {
        //<summary>
        //Поле предоставляющее почту пользователя
        //</summary>
        [Required(ErrorMessage = "Поле не заполнено.")]
        [StringLength(20, MinimumLength = 8, ErrorMessage = "Длина строки должна быть от 8 до 20 символов.")]
        [RegistrationEmail(new string[] { "@bk.ru", "@bk.com" }, ErrorMessage = "Не корректно указан адрес электронной почты.")]
        [EmailAddress(ErrorMessage = "Не корректно указан адрес электронной почты.")]
        public string Email { get; set; }

        //<summary>
        //Поле предоставляющее имя пользователя
        //</summary>
        [Required(ErrorMessage = "Поле не заполнено.")]
        [StringLength(20, MinimumLength = 8, ErrorMessage = "Длина строки должна быть от 8 до 20 символов.")]
        public string UserName { get; set; }

        //<summary>
        //Поле предоставляющее пароль пользователя
        //</summary>
        [Required(ErrorMessage = "Поле не заполнено.")]
        [StringLength(20, MinimumLength = 8, ErrorMessage = "Длина строки должна быть от 8 до 20 символов.")]
        public string Password { get; set; }

        //<summary>
        //Поле предоставляющее имя участника
        //</summary>
        [Required(ErrorMessage = "Поле не заполнено.")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Длина строки должна быть от 2 до 20 символов.")]
        public string Name { get; set; }

        //<summary>
        //Поле предоставляющее фамилию участника
        //</summary>
        [Required(ErrorMessage = "Поле не заполнено.")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Длина строки должна быть от 2 до 20 символов.")]
        public string MiddleName { get; set; }

        //<summary>
        //Поле предоставляющее Отчество участника
        //</summary>
        [Required(ErrorMessage = "Поле не заполнено.")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Длина строки должна быть от 2 до 20 символов.")]
        public string LastName { get; set; }

        //<summary>
        //Поле предоставляющее дату рождения участника
        //</summary>
        [RegistrationDateAge(ErrorMessage = "Поле не заполнено.")]
        public string DateAge { get; set; }

        //<summary>
        //Поле предоставляющее пол участника
        //</summary>
        public int PolId { get; set; }

        //<summary>
        //Список полов
        //</summary>
        public SelectList SelectListPolItems { get; set; }

        //<summary>
        //Поле предоставляющее идентификатор страны
        //</summary>
        public int CountryId { get; set; }

        //<summary>
        //Список стрна
        //</summary>
        public SelectList SelectListCountryItems { get; set; }

        //<summary>
        //Поле предоставляющее идентификатор домена
        //</summary>
        public string DomensId { get; set; }

        //<summary>
        //Список доменов
        //</summary>
        public SelectList SelectListDomensItems { get; set; }

    }
}
