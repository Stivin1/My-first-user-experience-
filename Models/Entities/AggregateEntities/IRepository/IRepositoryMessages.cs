using OpenSourceEnity.Models.Entities.SystemEntities;

namespace OpenSourceEnity.Models.Entities.AggregateEntities.IRepository
{
    //<summary>
    //Интерфейс репозитория предоставляющий методы обобщеннго интерфейса конкретного типа
    //</summary>
    public interface IRepositoryMessages :  IRepository<Message>
    {

    }
}
