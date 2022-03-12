using OpenSourceEnity.Models.ContextDb;
using OpenSourceEnity.Models.Entities.AggreagateLogEntities.IRepository;
using OpenSourceEnity.Models.Entities.AggreagateLogEntities.IUnitOfWork;
namespace OpenSourceEnity.Models.Entities.AggreagateLogEntities.UnitLogOfWork
{
    //<summary>
    //Класс предоставляющий реализацию единицы работы логирования 
    //и предоставляющий доступ к репозиториям логирования
    //</summary>
    public class UnitLogOfWork : IUnitLogOfWork
    {
        //<summary>
        //Свойство предоставляющее доступ к базе данных 
        //</summary>
        public ApplicationEnityContextdb ApplicationEnityContextdb { get; set; }

        //<summary>
        //Свойство предоставляющее доступ логированию 
        //</summary>
        public IRepositoryLogging RepositoryLogging { get; set; }

        //<summary>
        //Конструктор предоставляющий инициализацию параметров: 
        ///<param name="ApplicationEnityContextdb">Свой предоставляющее доступ к базе данных.</param>
        ///<param name="RepositoryLogging">Свойство предоставляющее доступ логированию.</param>
        //</summary>
        public UnitLogOfWork(
            ApplicationEnityContextdb ApplicationEnityContextdb,
            IRepositoryLogging RepositoryLogging
            )
        {
            this.ApplicationEnityContextdb = ApplicationEnityContextdb;
            this.RepositoryLogging = RepositoryLogging;
        }

        //<summary>
        //Метод отвечающий освобождение ресурсов после обращения к базе данных
        ///<param name=""></param>
        //</summary>
        public void Dispose()
        {
            ApplicationEnityContextdb.Dispose();
        }
    }
}
