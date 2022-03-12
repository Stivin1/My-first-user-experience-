using OpenSourceEnity.Models.Entities.AggreagateLogEntities.IRepository;

namespace OpenSourceEnity.Models.Entities.AggreagateLogEntities.IUnitOfWork
{
    //<summary>
    //Интерфейс репозитория
    //</summary>
    public interface IUnitLogOfWork
    {
        //<summary>
        //Свойство предоставляющие информацию о логировании
        //</summary>
        public IRepositoryLogging RepositoryLogging { get; set; }
    }
}
