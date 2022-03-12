using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace OpenSourceEnity.Models.Entities.SystemEntities
{
    //<summary>
    //Системная сущность стран
    //</summary>
    public class Country
    {
        //<summary>
        //Идентификатор страны
        //</summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        //<summary>
        //Наименование страны
        //</summary>
        public string Name { get; set; }

        //<summary>
        //Связь страны с участником
        //</summary>
        public List<Participant> Participant { get; set; } = new List<Participant>();
    }
}
