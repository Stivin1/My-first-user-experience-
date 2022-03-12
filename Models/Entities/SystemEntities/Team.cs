using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace OpenSourceEnity.Models.Entities.SystemEntities
{
    //<summary>
    //Системная сущность группы
    //</summary>
    public class Team
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        //<summary>
        //Наименование группы
        //</summary>
        public string Name { get; set; }

        //<summary>
        //Пользователи группы
        //</summary>
        public List<User> Users { get; set; } = new List<User>();
    }
}
