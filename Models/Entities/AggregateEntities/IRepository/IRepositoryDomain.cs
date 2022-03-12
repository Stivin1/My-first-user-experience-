using OpenSourceEnity.Models.Entities.SystemEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenSourceEnity.Models.Entities.AggregateEntities.IRepository
{
    public interface IRepositoryDomain : IRepository<Domain>
    {
    }
}
