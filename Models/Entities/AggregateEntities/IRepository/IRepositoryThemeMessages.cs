using OpenSourceEnity.Models.Entities.SystemEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenSourceEnity.Models.Entities.AggregateEntities.IRepository
{
    //<summary>
    //Интерфейс репозитория предоставляющий методы обобщеннго интерфейса конкретного типа
    //</summary>
    public interface IRepositoryThemeMessages : IRepository<ThemeMessage>
    {

    }
}
