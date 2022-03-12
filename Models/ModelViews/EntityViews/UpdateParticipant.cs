using Microsoft.AspNetCore.Mvc.Rendering;
using OpenSourceEnity.Models.Entities.SystemEntities;
using OpenSourceEnity.Models.ModelViews.EntityViewsAttributes.RegistrationAttributes;
using System.ComponentModel.DataAnnotations;

namespace OpenSourceEnity.Models.ModelViews.EntityViews
{
    //<summary>
    //Модель отвечающая за обновление данных участника
    //</summary>
    public class UpdateParticipant
    {
        //<summary>
        //Идентификатор пользователя
        //</summary>
        public string UserId { get; set; }

        //<summary>
        //Свойство предоставляющее данные участника
        //</summary>
        public Participant Participant { get; set; }

        //<summary>
        //Поле имя участника
        //</summary>
        [Required(ErrorMessage = "Поле не заполнено.")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Длина строки должна быть от 8 до 20 символов.")]
        public string Name { get; set; }

        //<summary>
        //Поле фамилия участника
        //</summary>
        [Required(ErrorMessage = "Поле не заполнено.")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Длина строки должна быть от 2 до 20 символов.")]
        public string MiddleName { get; set; }

        //<summary>
        //Поле отчество участника
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
        //Ccылка на коллекцию пола
        //</summary>
        public SelectList SelectListPolItems { get; set; }

        //<summary>
        //Поле предоставляющее идентификатор страны
        //</summary>
        public int CountryId { get; set; }

        //<summary>
        //Ccылка на коллекцию стран
        //</summary>
        public SelectList SelectListCountryItems { get; set; }

        //<summary>
        //Ccылка на коллекцию пола
        //</summary>
        public SelectList SelectListItemsPol { get; internal set; }
    }
}
