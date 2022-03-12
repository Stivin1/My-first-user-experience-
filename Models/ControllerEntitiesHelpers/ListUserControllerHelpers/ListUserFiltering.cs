using OpenSourceEnity.Models.Entities.SystemEntities;
using System.Collections.Generic;
using System.Linq;

namespace OpenSourceEnity.Models.ControllerEntitiesHelpers.ListUserControllerHelpers
{
    //<summary>
    //Класс реализующий фильтрацию участников на форме зарегистрированных участников
    //</summary>
    public class ListUserFiltering
    {
        //<summary>
        //Коллекция участников
        //</summary>
        public IEnumerable<Participant> Participants { get; set; }

        //<summary>
        //Конструктор предоставляющий инициализацию параметров: 
        ///<param name="Participants">Ссылка на коллекцию участников</param>
        //</summary>
        public ListUserFiltering(IEnumerable<Participant> Participants)
        {
            this.Participants = Participants;
        }

        //<summary>
        //Метод отвечающий за фильтрацию участника 
        ///<param name="MiddleName">Фамилия участника.</param>
        ///<param name="Name">Имя участника.</param>
        ///<param name="LastName">Отчество участника.</param>
        //</summary>
        public IEnumerable<Participant> ParticipantsFilter(string MiddleName, string Name, string LastName)
        {
            if (!string.IsNullOrEmpty(MiddleName))
            {
                Participants = Participants.Where(t => t.MiddleName.Contains(MiddleName));
            }

            if (!string.IsNullOrEmpty(Name))
            {
                Participants = Participants.Where(t => t.Name.Contains(Name));
            }

            if (!string.IsNullOrEmpty(LastName))
            {
                Participants = Participants.Where(t => t.LastName.Contains(LastName));
            }

            return Participants;
        }
    }
}
