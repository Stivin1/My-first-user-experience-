using System.ComponentModel.DataAnnotations;

namespace OpenSourceEnity.Models.ModelViews.EntityViews
{
    //<summary>
    //Модель отвечающая за пред регистрацию на главной странице 
    //</summary>
    public class Front
    {
        //<summary>
        //Свойство отвечающее за получение почты пользователя на форме авторизации
        //</summary>
        [Required(ErrorMessage = "Поле не заполнено")]
        [StringLength(20, MinimumLength = 8, ErrorMessage = "Длина строки должна быть от 8 до 20 символов")]
        [EmailAddress(ErrorMessage = "Не корректно указан адрес электронной почты")]
        public string Email { get; set; }

        //<summary>
        //Количество зарегистрированных пользователей
        //</summary>
        public int Count { get; set; }
    }
}
