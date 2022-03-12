using Microsoft.AspNetCore.Identity;
using OpenSourceEnity.Models.Entities.AggreagateLogEntities.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace OpenSourceEnity.Models.Entities.SystemEntities
{
    //<summary>
    //Системная сущность пользователя
    //</summary>
    public class User : IdentityUser
    {
        //<summary>
        //Возраст пользователя
        //</summary>
        public int Age { get; set; }

        //<summary>
        //Дата создания аккаунта
        //</summary>
        public string DateCreate { get; set; }

        //<summary>
        //Дата изменения аккаунта
        //</summary>
        public string DateChanges { get; set; }

        //<summary>
        //Идентификатор домена
        //</summary>
        [ForeignKey("DomainId")]
        public string DomainId { get; set; }

        //<summary>
        //Связь с участником
        //</summary>
        public Domain Domain { get; set; }

        //<summary>
        //Связь с участником
        //</summary>
        public Participant Participant { get; set; }

        //<summary>
        //Связь группы с пользователем
        //</summary>
        public List<Team> Teams { get; set; } = new List<Team>();

        //<summary>
        //Связь с логирование пользователя
        //</summary>
        public List<Logging> Loggings { get; set; } = new List<Logging>();

        //<summary>
        //Связь адреса сообщений с пользователем
        //</summary>
        public List<AddresseeMessage> AddresseeMessage { get; set; } = new List<AddresseeMessage>();
    }
}
