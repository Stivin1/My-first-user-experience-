using OpenSourceEnity.Models.ControllerEntitiesHelpers.ListUserMessageControllerHelpers;
using OpenSourceEnity.Models.Entities.SystemEntities;
using System.Collections.Generic;

namespace OpenSourceEnity.Models.ModelViews.EntityViews
{
    //<summary>
    //Модель отвечающая за обновление данных участника
    //</summary>
    public class UserListMessage
    {
        //<summary>
        //Идентификатор прользователя
        //</summary>
        public string UserId { get; set; }

        //<summary>
        //Коллекция пользователей 
        //</summary>
        public IEnumerable<User> Users { get; set; }

        //<summary>
        //Коллекция участников 
        //</summary>
        public IEnumerable<Participant> Participants { get; set; }

        //<summary>
        //Свойство предоставляющее набор методов для сертировки данных
        //</summary>
        public ListUserMessageSorting ListUserMessageSorting { get; set; }

        //<summary>
        //Свойство предоставляющее набор методов для фильтрации данных
        //</summary>
        public ListUesrMessageFiltering ListUesrMessageFiltering { get; set; }

        //<summary>
        //Свойство предоставляющее набор полей и свойст для пагинации страницы
        //</summary>
        public ListUserMessagePagination ListUserMessagePagination { get; set; }
    }
}
