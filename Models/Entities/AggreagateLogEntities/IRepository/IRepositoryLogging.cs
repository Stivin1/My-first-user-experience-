using OpenSourceEnity.Models.Entities.AggreagateLogEntities.Entities;

namespace OpenSourceEnity.Models.Entities.AggreagateLogEntities.IRepository
{
    //<summary>
    //Интерфейс реализующий репозитория конкретного типа
    //</summary>
    public interface IRepositoryLogging : IRepository<Logging>
    {
        //<summary>
        //Дополнительное свойство предоставляющее логирования
        //</summary>
        public LoggingEnum loggingEnum { get; set; }
    }
}
