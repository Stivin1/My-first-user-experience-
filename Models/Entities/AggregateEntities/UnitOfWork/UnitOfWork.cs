using OpenSourceEnity.Models.ContextDb;
using OpenSourceEnity.Models.Entities.AggregateEntities.IRepository;

namespace OpenSourceEnity.Models.Entities.AggregateEntities.UnitOfWork
{
    //<summary>
    //Класс предоставляющий реализацию единицы работы
    //репозиториев для работы с пользователями 
    //</summary>
    public class UnitOfWork : IUnitOfWork
    {
        //<summary>
        //Свойство предоставляющее доступ к базе данных 
        //</summary>
        public ApplicationEnityContextdb ApplicationEnityContextdb { get; set; }

        //<summary>
        //Интерфейсное свойство предоставляющие ссылку для работы с методам конкретного типа
        //</summary>
        public IRepositoryParticipant RepositoryParticipant { get; set; }

        //<summary>
        //Интерфейсное свойство предоставляющие ссылку для работы с методам конкретного типа
        //</summary>
        public IRepositoryCountry RepositoryCountry { get; set; }

        //<summary>
        //Интерфейсное свойство предоставляющие ссылку для работы с методам конкретного типа
        //</summary>
        public IRepositoryPol RepositoryPol { get; set; }

        //<summary>
        //Интерфейсное свойство предоставляющие ссылку для работы с методам конкретного типа
        //</summary>
        public IRepositoryTeam RepositoryTeam { get; set; }

        //<summary>
        //Интерфейсное свойство предоставляющие ссылку для работы с методам конкретного типа
        //</summary>
        public IRepositoryThemeMessages RepositoryThemeMessages { get; set; }

        //<summary>
        //Интерфейсное свойство предоставляющие ссылку для работы с методам конкретного типа
        //</summary>
        public IRepositoryMessages RepositoryMessages { get; set; }

        //<summary>
        //Интерфейсное свойство предоставляющие ссылку для работы с методам конкретного типа
        //</summary>
        public IRepositoryDomain RepositoryDomains { get; set; }

        //<summary>
        //Интерфейсное свойство предоставляющие ссылку для работы с методам конкретного типа
        //</summary>
        public IRepositoryParticipant_AUD IRepositoryParticipant_AUD { get; set; }

        //<summary>
        //Конструктор предоставляющий инициализацию параметров: 
        ///<param name="ApplicationEnityContextdb">Свой предоставляющее доступ к базе данных</param>
        ///<param name="RepositoryParticipant">Свойство предоставляющие к набору методов участника</param>
        ///<param name="RepositoryCountry">Свойство предоставляющее к набору методов стран</param>
        ///<param name="RepositoryTeam">Свойство предоставляющее к набору методов группы</param>
        ///<param name="RepositoryPol">Свойство предоставляющее к набору методов пола</param>
        ///<param name="RepositoryThemeMessages">Свойство предоставляющее к набору методов темы сообщения</param>
        ///<param name="RepositoryMessages">Свойство предоставляющее к набору методов сообщения</param>
        ///<param name="RepositoryDomains">Свойство предоставляющее к набору методов домена</param>
        ///<param name="IRepositoryParticipant_AUD">Свойство предоставляющее к набору методов сохраненных данные участника</param>
        //</summary>
        public UnitOfWork(
            ApplicationEnityContextdb ApplicationEnityContextdb,
            IRepositoryParticipant RepositoryParticipant,
            IRepositoryCountry RepositoryCountry,
            IRepositoryTeam RepositoryTeam,
            IRepositoryPol RepositoryPol,
            IRepositoryThemeMessages RepositoryThemeMessages,
            IRepositoryMessages RepositoryMessages,
            IRepositoryDomain RepositoryDomains,
            IRepositoryParticipant_AUD IRepositoryParticipant_AUD
            )
        {
            this.ApplicationEnityContextdb = ApplicationEnityContextdb;
            this.RepositoryParticipant = RepositoryParticipant;
            this.RepositoryCountry = RepositoryCountry;
            this.RepositoryTeam = RepositoryTeam;
            this.RepositoryPol = RepositoryPol;
            this.RepositoryThemeMessages = RepositoryThemeMessages;
            this.RepositoryMessages = RepositoryMessages;
            this.RepositoryDomains = RepositoryDomains;
            this.IRepositoryParticipant_AUD = IRepositoryParticipant_AUD;
        }

        //<summary>
        //Метод отвечающий за освобождение ресурсов после обращения к базе данных
        ///<param name=""></param>
        //</summary>
        public void Dispose()
        {
            ApplicationEnityContextdb.Dispose();
        }
    }
}
