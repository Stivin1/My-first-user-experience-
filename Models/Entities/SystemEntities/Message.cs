using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace OpenSourceEnity.Models.Entities.SystemEntities
{
    //<summary>
    //Системная сущность сообщения
    //</summary>
    public class Message
    {
        //<summary>
        //Идентификатор сообщения
        //</summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        //<summary>
        //Текст сообщения
        //</summary>
        public string Text { get; set; }

        //<summary>
        //Дата создения сообщения
        //</summary>
        public string DataCreate { get; set; }

        //<summary>
        //Связь сообщения с темой
        //</summary>
        public ThemeMessage ThemeMessage { get; set; }

        //<summary>
        //Внешний ключ с темой сообщения
        //</summary>
        [ForeignKey("ThemeMessageId")]
        public int ThemeMessageId { get; set; }

        //<summary>
        //Связь сообщения с адресом 
        //</summary>
        public List<AddresseeMessage> addresseeMessages { get; set; } = new List<AddresseeMessage>();
    }
}
