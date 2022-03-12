using OpenSourceEnity.Models.Entities.SystemEntities;
using System.Collections.Generic;

namespace OpenSourceEnity.Models.ModelViews.EntityViews
{
    //<summary>
    //Модель отвечающая за добавление группы пользователю
    //</summary>
    public class TeamUser
    {
        //<summary>
        //Идентификатор прользователя
        //</summary>
        public string UserId { get; set; }

        //<summary>
        //Поле наименование пользователя
        //</summary>
        public string UserName { get; set; }

        //<summary>
        //Коллекция добавленных групп пользователю
        //</summary>
        public IEnumerable<string> TeamsUser { get; set; }

        //<summary>
        //Коллекция добавленных групп
        //</summary>
        public IEnumerable<Team> IdentityTeams { get; set; }
    }
}
