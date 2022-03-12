using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace OpenSourceEnity.Models.Entities.SystemEntities
{
    //<summary>
    //Системная сущность справочника пола
    //</summary>
    public class Pol
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        //<summary>
        //Наименование поля
        //</summary>
        public string Name { get; set; }

        //<summary>
        //Связь пола с участником
        //</summary>
        public List<Participant> Participant { get; set; } = new List<Participant>();
    }
}
