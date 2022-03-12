using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenSourceEnity.Models.Entities.AggregateEntities.IRepository
{
    //<summary>
    //Обобщенный интерфейс репозитория предоставляющий конкретны тип в реализующем классе
    //</summary>
    public interface IRepository<T> where T: class
    {
        //<summary>
        //Метод отвечающий за добавление данных в базу данных и возвращающий задачу типа 
        ///<param name="T">Обобщенный тип предоставляющий конкретный тип в реализующим классе.</param>
        //</summary>
        public Task<int> Create(T option);

        //<summary>
        //Метод отвечающий за получение конкретного типа данных
        ///<param name="T">Обобщенный тип предоставляющий конкретный тип в реализующим классе.</param>
        //</summary>
        public Task<T> GetEntity(T option);

        //<summary>
        //Метод отвечающий за получение списка конкретного типа данных
        //</summary>
        public Task<IEnumerable<T>> GetEntitys();

        //<summary>
        //Метод отвечающий за обновление конкретного типа данных
        ///<param name="T">Обобщенный тип предоставляющий конкретный тип в реализующим классе.</param>
        //</summary>
        public Task<int> Update(T option);

        //<summary>
        //Метод отвечающий за удаление конкретного типа данных
        ///<param name="T">Обобщенный тип предоставляющий конкретный тип в реализующим классе.</param>
        //</summary>
        public Task<int> Delete(T option);
    }
}
