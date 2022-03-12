using OpenSourceEnity.Models.Entities.SystemEntities;
using System.ComponentModel.DataAnnotations.Schema;

namespace OpenSourceEnity.Models.Entities.AggreagateLogEntities.Entities
{
    //<summary>
    //Системная сущность логирования пользователей
    //</summary>
    public class Logging
    {
        //<summary>
        //Идентификатор логирования
        //</summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        //<summary>
        //Дополнительная информация о логировании
        //</summary>
        public string Description { get; set; }

        //<summary>
        //Дата создания лога
        //</summary>
        public string DateCreate { get; set; }

        //<summary>
        //Связь со справочником логирования
        //</summary>
        public LoggingInformation loggingInformation { get; set; }

        //<summary>
        //Внешний ключ со справочником логирования
        //</summary>
        [ForeignKey("LoggingInformationId")]
        public int LoggingInformationId { get; set; }

        //<summary>
        //Связь логирования с пользователем
        //</summary>
        public User User { get; set; }

        //<summary>
        //Внешний ключ пользователя
        //</summary>
        [ForeignKey("UserId")]
        public string UserId { get; set; }
    }
}
