using System.ComponentModel.DataAnnotations;

namespace OpenSourceEnity.Models.ModelViews.EntityViews
{
    //<summary>
    //Модель отвечающая за обновление пользовательских данных
    //</summary>
    public class UserUpdate
    {
        //<summary>
        //Идентификатор прользователя
        //</summary>
        public string UserId { get; set; }

        //<summary>
        //Имя пользователя
        //</summary>
        public string UserName { get; set; }

        //<summary>
        //Старый пароль
        //</summary>
        [Required(ErrorMessage = "Поле не заполнено.")]
        [StringLength(20, MinimumLength = 8, ErrorMessage = "Длина строки должна быть от 8 до 20 символов.")]
        public string OldPassword { get; set; }

        //<summary>
        //Новый пароль
        //</summary>
        [Required(ErrorMessage = "Поле не заполнено.")]
        [StringLength(20, MinimumLength = 8, ErrorMessage = "Длина строки должна быть от 8 до 20 символов.")]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }
    }
}
