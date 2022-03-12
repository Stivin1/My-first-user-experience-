using OpenSourceEnity.Models.Entities.SystemEntities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenSourceEnity.Models.Entities.AggregateEntities.IRepository
{
    //<summary>
    //Интерфейс репозитория предоставляющий методы обобщеннго интерфейса конкретного типа
    //</summary>
    public interface IRepositoryTeam : IRepository<Team>
    {
        //<summary>
        //Дополнительный метод отвечающий за получения списка групп пользователя
        ///<param name="UserId">Идентификатор пользователя.</param>
        //</summary>
        public Task<List<string>> GetEntitys(string UserId);

        //<summary>
        //Дополнительный метод отвечающий за добавления групп пользователю 
        ///<param name="Users">Ссылка на пользователя.</param>
        ///<param name="Teams">Список групп.</param>
        //</summary>
        public Task<int> AddTeamsEntitys(User Users, IEnumerable<string> Teams);

        //<summary>
        //Дополнительный метод отвечающий за удаление групп пользователя 
        ///<param name="Users">Ссылка на пользователя.</param>
        ///<param name="Teams">Список групп.</param>
        //</summary>
        public Task<int> RemoveTeamsEntitys(User Users, IEnumerable<string> Teams);
    }
}
