using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace OpenSourceEnity.Models.Entities.SystemEntities
{
    //<summary>
    //Системная сущность участника
    //</summary>
    public class Participant
    {
        //<summary>
        //Идентификатор участника
        //</summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string id { get; set; }

        //<summary>
        //Имя участника
        //</summary>
        public string Name { get; set; }

        //<summary>
        //Фамилия участника
        //</summary>
        public string MiddleName { get; set; }

        //<summary>
        //Отчество участника
        //</summary>
        public string LastName { get; set; }

        //<summary>
        //Дата рождения участника
        //</summary>
        public string DateAge { get; set; }

        //<summary>
        //Внешний ключ пользователя
        //</summary>
        [ForeignKey("UserId")]
        public string UserId { get; set; }

        //<summary>
        //Связь участника с пользователем
        //</summary>
        public User User { get; set; }

        //<summary>
        //Внешний ключ пола
        //</summary>
        [ForeignKey("PolId")]
        public int PolId { get; set; }

        //<summary>
        //Связь участника с полом
        //</summary>
        public Pol Pol { get; set; }

        //<summary>
        //Внешний ключ страны участника
        //</summary>
        [ForeignKey("CountryId")]
        public int CountryId { get; set; }

        //<summary>
        //Связь участника со страной
        //</summary>
        public Country Country { get; set; }


        public virtual List<Participant_AUD> Participant_AUD { get; set; } = new List<Participant_AUD>();

    }
}
