using OpenSourceEnity.Models.Entities.SystemEntities;
using System.Collections.Generic;
using System.Linq;

namespace OpenSourceEnity.Models.ControllerEntitiesHelpers.ListUserMessageControllerHelpers
{
    //<summary>
    //Класс реализующий фильтрацию пользователей на форме отправки сообщений пользователям
    //</summary>
    public class ListUesrMessageFiltering
    {
        //<summary>
        //Коллекция пользователей
        //</summary>
        public IEnumerable<User> Users { get; set; }

        //<summary>
        //Конструктор предоставляющий инициализацию параметров: 
        ///<param name="Participants">Ссылка на коллекцию пользователей</param>
        //</summary>
        public ListUesrMessageFiltering(IEnumerable<User> Users)
        {
            this.Users = Users;
        }

        //<summary>
        //Метод отвечающий за фильтрацию пользователей 
        ///<param name="Email">Почта пользователя.</param>
        ///<param name="UserName">Имя пользователя.</param>
        //</summary>
        public IEnumerable<User> ParticipantsFilter(string Email, string UserName)
        {
            if (!string.IsNullOrEmpty(Email))
            {
                Users = Users.Where(t => t.Email.Contains(Email));
            }

            if (!string.IsNullOrEmpty(UserName))
            {
                Users = Users.Where(t => t.UserName.Contains(UserName));
            }

            return Users;
        }
    }
}
