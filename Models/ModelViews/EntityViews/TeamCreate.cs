using System.ComponentModel.DataAnnotations;

namespace OpenSourceEnity.Models.ModelViews.EntityViews
{
    //<summary>
    //Модель отвечающая за создание группы
    //</summary>
    public class TeamCreate
    {
        //<summary>
        //Идентификатор пользователя
        //</summary>
        public string UserId { get; set; }

        //<summary>
        //Поле наименование группы
        //</summary>
        [Required(ErrorMessage = "Поле не заполнено")]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "Длина строки должна быть от 4 до 20 символов")]
        public string Name { get; set; }
    }
}
