using OpenSourceEnity.Models.ControllerEntitiesHelpers.ListUserControllerHelpers;
using OpenSourceEnity.Models.Entities.SystemEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenSourceEnity.Models.ControllerEntitiesHelpers.ListUserControllerHelpers
{
    //<summary>
    //Класс реализующий сортировку на форме зарегистрированных участников
    //</summary>
    public class ListParticiapntSorting : Sorting
    {
        //<summary>
        //Конструктор предоставляющий инициализацию параметров: 
        ///<param name="sorting">Ссылка на полученную константу перечисления.</param>
        //</summary>
        public ListParticiapntSorting(Sort sorting)
        {
            Default = sorting;
            Name = sorting == Sort.NameAsc ? Sort.NameDesc : Sort.NameAsc;
            MiddleName = sorting == Sort.MiddleNameAsc ? Sort.MiddleNameDesc : Sort.MiddleNameAsc;
            LastName = sorting == Sort.LastNameAsc ? Sort.LastNameDesc : Sort.LastNameAsc;
        }

        //<summary>
        //Метод отвечающий за сортировку участника 
        ///<param name="participants">Ссылка на коллекцию участников.</param>
        ///<param name="sorting">Константа сортировки.</param>
        //</summary>
        public IEnumerable<Participant> ParticipantsSorting(IEnumerable<Participant> participants, Sort sorting)
        {
            switch (sorting)
            {
                case Sort.NameAsc:
                    participants = participants.OrderBy(t => t.Name); break;
                case Sort.NameDesc:
                    participants = participants.OrderByDescending(t => t.Name); break;
                case Sort.MiddleNameAsc:
                    participants = participants.OrderBy(s => s.MiddleName); break;
                case Sort.MiddleNameDesc:
                    participants = participants.OrderByDescending(t => t.MiddleName); break;
                case Sort.LastNameAsc:
                    participants = participants.OrderBy(s => s.LastName); break;
                case Sort.LastNameDesc:
                    participants = participants.OrderByDescending(t => t.LastName); break;
                default: throw new Exception("Error sorting");
            }

            return participants;
        }
    }
}
