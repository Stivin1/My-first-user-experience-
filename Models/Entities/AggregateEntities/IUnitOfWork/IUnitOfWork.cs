using System;

namespace OpenSourceEnity.Models.Entities.AggregateEntities.IRepository
{
    //<summary>
    //Интерфейс единицы работы предоставляющий ссылки на репозитории к конкретным источникам данных
    //</summary>
    public interface IUnitOfWork : IDisposable
    {
        //<summary>
        //Интерфейсное свойство предоставляющиее доступ к методам конкретного типа
        //</summary>
        public IRepositoryParticipant RepositoryParticipant { get; set; }

        //<summary>
        //Интерфейсное свойство предоставляющиее доступ к методам конкретного типа
        //</summary>
        public IRepositoryCountry RepositoryCountry { get; set; }

        //<summary>
        //Интерфейсное свойство предоставляющиее доступ к методам конкретного типа
        //</summary>
        public IRepositoryPol RepositoryPol { get; set; }

        //<summary>
        //Интерфейсное свойство предоставляющиее доступ к методам конкретного типа
        //</summary>
        public IRepositoryTeam RepositoryTeam { get; set; }
        //<summary>
        //Интерфейсное свойство предоставляющиее доступ к методам конкретного типа
        //</summary>

        public IRepositoryThemeMessages RepositoryThemeMessages { get; set; }

        //<summary>
        //Интерфейсное свойство предоставляющиее доступ к методам конкретного типа
        //</summary>
        public IRepositoryMessages RepositoryMessages { get; set; }

        //<summary>
        //Интерфейсное свойство предоставляющиее доступ к методам конкретного типа
        //</summary>
        public IRepositoryDomain RepositoryDomains { get; set; }

        //<summary>
        //Интерфейсное свойство предоставляющиее доступ к методам конкретного типа
        //</summary>
        public IRepositoryParticipant_AUD IRepositoryParticipant_AUD { get; set; }
    }
}
