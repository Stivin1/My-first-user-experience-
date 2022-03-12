using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OpenSourceEnity.Models.Entities.SystemEntities
{
    //<summary>
    //Системная сущность домена 
    //</summary>
    public class Domain
    {
        //<summary>
        //Идентификатор домена
        //</summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        //<summary>
        //Наименование домена
        //</summary>
        public string Name { get; set; }

        //<summary>
        //Связь пользователя с доменом
        //</summary>
        public List<User> Users { get; set; } = new List<User>();
    }
}
