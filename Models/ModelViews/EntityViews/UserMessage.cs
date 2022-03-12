using System.ComponentModel.DataAnnotations;

namespace OpenSourceEnity.Models.ModelViews.EntityViews
{
    //<summary>
    //Модель отвечающая отправку сообщения
    //</summary>
    public class UserMessage
    {
        //<summary>
        //Идентификатор прользователя
        //</summary>
        public string UserId { get; set; }

        //<summary>
        //Идентификатор прользователя получателя сообщения
        //</summary>
        public string UserIdRecipient { get; set; }

        //<summary>
        //Наименование пользователя отправителя
        //</summary>
        public string UserName { get; set; }

        //<summary>
        //Наименование пользователя получателя
        //</summary>
        public string UserNameRecipient { get; set; }

        //<summary>
        //Тема сообщения
        //</summary>
        [Required(ErrorMessage = "Тема сообщения не заполнена.")]
        [StringLength(40, MinimumLength = 2, ErrorMessage = "Длина строки должна быть от 2 до 40 символов.")]
        public string Theme { get; set; }

        //<summary>
        //Текст сообщения
        //</summary>
        [Required(ErrorMessage = "Не возможно отправить пустое сообщение.")]
        [StringLength(2000, MinimumLength = 0, ErrorMessage = "Длина строки должна быть от 0 до 2000 символов.")]
        public string Text { get; set; }
    }
}
