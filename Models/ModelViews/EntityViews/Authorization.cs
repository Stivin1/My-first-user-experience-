using System.ComponentModel.DataAnnotations;

namespace OpenSourceEnity.Models.ModelViews.EntityViews
{
    //<summary>
    //Модель отвечающая за авторизацию пользователя
    //</summary>
    public class Authorization
    {
        //<summary>
        //Свойство для проверки является ли адрес локальным
        //</summary>
        public string UrlLink { get; set; }

        //<summary>
        //Свойство отвечающее за получение почты пользователя на форме авторизации
        //</summary>
        [Required(ErrorMessage = "Поле не заполнено")]
        [StringLength(20, MinimumLength = 8, ErrorMessage = "Длина строки должна быть от 8 до 20 символов")]
        [EmailAddress(ErrorMessage = "Не корректно указан адрес электронной почты")]
        public string Email { get; set; }

        //<summary>
        //Свойство отвечающее за получение пароля пользователя на форме авторизации
        //</summary>
        [Required(ErrorMessage = "Поле не заполнено")]
        [StringLength(20, MinimumLength = 8, ErrorMessage = "Длина строки должна быть от 8 до 20 символов")]
        public string Password { get; set; }
    }
}
