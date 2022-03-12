using OpenSourceEnity.Models.Entities.SystemEntities;
using System.Collections.Generic;
using System.Linq;

namespace OpenSourceEnity.Models.ControllerEntitiesHelpers.ListReceivMessageControllerHelpers
{
    //<summary>
    //Класс реализующий фильтрацию участников на форме полученных сообщений
    //</summary>
    public class ListReceivMessageFiltering
    {
        //<summary>
        //Коллекция участников
        //</summary>
        public IEnumerable<AddresseeMessage> AddresseeMessage { get; set; }

        //<summary>
        //Конструктор предоставляющий инициализацию параметров: 
        ///<param name="Participants">Ссылка на коллекцию участников</param>
        //</summary>
        public ListReceivMessageFiltering(IEnumerable<AddresseeMessage> AddresseeMessage)
        {
            this.AddresseeMessage = AddresseeMessage;
        }

        //<summary>
        //Метод отвечающий за фильтрацию участника 
        ///<param name="MiddleName">Фамилия участника.</param>
        ///<param name="Name">Имя участника.</param>
        ///<param name="LastName">Отчество участника.</param>
        //</summary>
        public IEnumerable<AddresseeMessage> ParticipantsFilter(string MiddleName, string Name, string LastName)
        {
            if (!string.IsNullOrEmpty(MiddleName))
            {
                AddresseeMessage = AddresseeMessage.Where(t => t.User.Participant.MiddleName.Contains(MiddleName)); 
            }

            if (!string.IsNullOrEmpty(Name))
            {
                AddresseeMessage = AddresseeMessage.Where(t => t.User.Participant.Name.Contains(Name));
            }

            if (!string.IsNullOrEmpty(LastName))
            {
                AddresseeMessage = AddresseeMessage.Where(t => t.User.Participant.LastName.Contains(LastName));
            }

            return AddresseeMessage;
        }
    }
}
