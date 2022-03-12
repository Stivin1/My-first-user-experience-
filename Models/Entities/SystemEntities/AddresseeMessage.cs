using System.ComponentModel.DataAnnotations.Schema;

namespace OpenSourceEnity.Models.Entities.SystemEntities
{
    //<summary>
    //Системная сущность адреса сообщения
    //</summary>
    public class AddresseeMessage
    {
        //<summary>
        //Идентификатор сообщения
        //</summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        //<summary>
        //Связь отправки сообщения с таблицой сообщений
        //</summary>
        public Message Message { get; set; }

        //<summary>
        //Внешний ключ с табликой сообещний
        //</summary>
        [ForeignKey("MessageId")]
        public int MessageId { get; set; }

        //<summary>
        //Связь адреса сообщений с пользователей
        //</summary>
        public User User { get; set; }

        //<summary>
        //Внешний ключ с таблийой пользователя
        //</summary>
        [ForeignKey("UserId")]
        public string UserId { get; set; }

        //<summary>
        //Внешний ключ получателя сообщения
        //</summary>
        [ForeignKey("RecipientId")]
        public string RecipientId { get; set; }
    }
}
