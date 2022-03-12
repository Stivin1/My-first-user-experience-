using OpenSourceEnity.Models.ControllerEntitiesHelpers;
using OpenSourceEnity.Models.ControllerEntitiesHelpers.ListUserControllerHelpers;
using OpenSourceEnity.Models.Entities.SystemEntities;
using System.Collections.Generic;

namespace OpenSourceEnity.Models.ModelViews.EntityViews
{
    //<summary>
    //Модель отвечающая за вывод пользователей на стринце
    //</summary>
    public class ListUser
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
        public IEnumerable<Participant> Participants { get; set; }

        //<summary>
        //Свойство для доступа к методам сортировки 
        //</summary>
        public ListParticiapntSorting listParticiapntSorting { get; set; }

        //<summary>
        //Свойство для доступа к методам фильтарации 
        //</summary>
        public ListUserFiltering listUserFiltering { get; set; }

        //<summary>
        //Свойство для доступа к данным пагинации 
        //</summary>
        public ListUserPagination ListUserPagination { get; set; }
       
    }
}
