using OpenSourceEnity.Models.ControllerEntitiesHelpers.ListReceivMessageControllerHelpers;
using OpenSourceEnity.Models.Entities.SystemEntities;
using System.Collections.Generic;

namespace OpenSourceEnity.Models.ModelViews.EntityViews
{
    //<summary>
    //Модель отвечающая за вывод сообщений пользователей на стринце
    //</summary>
    public class ReceivingMessage
    {
        //<summary>
        //Поле предоставляющее пользователя
        //</summary>
        public string UserId { get; set; }

        //<summary>
        //Коллекция пользователей 
        //</summary>
        public IEnumerable<User> Users { get; set; }

        //<summary>
        //Коллекция сотрудников 
        //</summary>
        public IEnumerable<AddresseeMessage> AddresseeMessage { get; set; }

        //<summary>
        //Свойство для доступа к методам сортировки 
        //</summary>
        public ListReceivMessageSorting ListReceivMessageSorting { get; set; }

        //<summary>
        //Свойство для доступа к методам фильтарации 
        //</summary>
        public ListReceivMessageFiltering ListReceivMessageFiltering { get; set; }

        //<summary>
        //Свойство для доступа к данным пагинации 
        //</summary>
        public ListReceivMessagePagination ListReceivMessagePagination { get; set; }
    }
}
