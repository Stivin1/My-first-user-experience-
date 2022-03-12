using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OpenSourceEnity.Models.Entities.SystemEntities
{
    //<summary>
    //Системная сущность темы сообщения
    //</summary>
    public class ThemeMessage
    {
        //<summary>
        //Идентификатор темы сообщения
        //</summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        //<summary>
        //Тема сообщения
        //</summary>
        public string Theme { get; set; }

        //<summary>
        //Связь сообщения с темой
        //</summary>
        public Message Message { get; set; }
    }
}
