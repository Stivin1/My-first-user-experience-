using System.Threading.Tasks;
using static OpenSourceEnity.Models.Entities.AggreagateLogEntities.Entities.LoggingEnum;

namespace OpenSourceEnity.Models.Entities.AggreagateLogEntities.IRepository
{
    //<summary>
    //Обобщенный интерфейс репозитория предоставляющий конкретны тип в реализующем классе
    //</summary>
    public interface IRepository<T> where T : class
    {
        //<summary>
        //Метод отвечающий за обработку логирования пользователя
        ///<param name="user">Идентификатор пользователя.</param>
        ///<param name="LogInfo">Справочник логирования.</param>
        //</summary>
        public Task<int> InsertLog(string user, InformationLoggingEnum LogInfo);
    }
}
