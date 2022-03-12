using OpenSourceEnity.Models.Entities.SystemEntities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenSourceEnity.Models.ControllerEntitiesHelpers.ListReceivMessageControllerHelpers
{
    //<summary>
    //Класс реализующий сортировку пользователей на форме отправи сообщений
    //</summary>
    public class ListReceivMessageSorting : Sorting
    {
        //<summary>
        //Конструктор предоставляющий инициализацию параметров: 
        ///<param name="sorting">Ссылка на полученную константу перечисления.</param>
        //</summary>
        public ListReceivMessageSorting(ReceivSort sorting)
        {
            Default = sorting;
            Name = sorting == ReceivSort.NameAsc ? ReceivSort.NameDesc : ReceivSort.NameAsc;
            MiddleName = sorting == ReceivSort.MiddleNameAsc ? ReceivSort.MiddleNameDesc : ReceivSort.MiddleNameAsc;
            LastName = sorting == ReceivSort.LastNameAsc ? ReceivSort.LastNameDesc : ReceivSort.LastNameAsc;
        }

        //<summary>
        //Метод отвечающий за сортировку участника 
        ///<param name="MiddleName">Фамилия участника.</param>
        ///<param name="Name">Имя участника.</param>
        ///<param name="LastName">Отчество участника.</param>
        //</summary>
        public IEnumerable<AddresseeMessage> ParticipantsSorting(IEnumerable<AddresseeMessage> AddresseeMessage, ReceivSort sorting)
        {
            switch (sorting)
            {
                case ReceivSort.NameAsc:
                    AddresseeMessage = AddresseeMessage.OrderBy(t => t.User.Participant.Name); break;
                case ReceivSort.NameDesc:
                    AddresseeMessage = AddresseeMessage.OrderByDescending(t => t.User.Participant.Name); break;
                case ReceivSort.MiddleNameAsc:
                    AddresseeMessage = AddresseeMessage.OrderBy(s => s.User.Participant.MiddleName); break;
                case ReceivSort.MiddleNameDesc:
                    AddresseeMessage = AddresseeMessage.OrderByDescending(t => t.User.Participant.MiddleName); break;
                case ReceivSort.LastNameAsc:
                    AddresseeMessage = AddresseeMessage.OrderBy(s => s.User.Participant.LastName); break;
                case ReceivSort.LastNameDesc:
                    AddresseeMessage = AddresseeMessage.OrderByDescending(t => t.User.Participant.LastName); break;
                case ReceivSort.UserNameAsc:
                    AddresseeMessage = AddresseeMessage.OrderByDescending(t => t.User.UserName); break;
                case ReceivSort.UserNameDesc:
                    AddresseeMessage = AddresseeMessage.OrderByDescending(t => t.User.UserName); break;
                default: throw new Exception("Error sorting");
            }

            return AddresseeMessage;
        }
    }
}
