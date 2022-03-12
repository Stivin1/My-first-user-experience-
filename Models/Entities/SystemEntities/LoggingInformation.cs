using OpenSourceEnity.Models.Entities.AggreagateLogEntities.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace OpenSourceEnity.Models.Entities.SystemEntities
{
    //<summary>
    //Системная сущность справочника логирования
    //</summary>
    public class LoggingInformation
    {
        //<summary>
        //Идентификатор сущности
        //</summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        //<summary>
        //Наименование логирования 
        //</summary>
        public string Name { get; set; }

        //<summary>
        //Связь справочника с логированием
        //</summary>
        public List<Logging> loggings { get; set; } = new List<Logging>();
    }
}
