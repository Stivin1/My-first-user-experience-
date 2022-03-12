using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Logging;
using OpenSourceEnity.Models.ApplicationContextdb.ApplictionConnection.LogetContextdb;
using OpenSourceEnity.Models.ContextDb;
using OpenSourceEnity.Models.Entities.AggregateEntities.IRepository;
using OpenSourceEnity.Models.Entities.SystemEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenSourceEnity.Models.Entities.AggregateEntities.Repository
{
    public class RepositoryDomain : IRepositoryDomain
    {
        //<summary>
        //Свойство для работы с источником данных
        //</summary>
        private ApplicationEnityContextdb optiondb { get; set; }

        //<summary>
        //Конструктор предоставляющий инициализацию параметров: 
        ///<param name="optiondb">Свой предоставляющее доступ к базе данных.</param>
        //</summary>
        public RepositoryDomain(ApplicationEnityContextdb optiondb)
        {
            this.optiondb = optiondb;
        }

        public Task<int> Create(Domain option)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(Domain option)
        {
            throw new NotImplementedException();
        }

        public async Task<Domain> GetEntity(Domain option)
        {
            optiondb.GetService<ILoggerFactory>().AddProvider(new MyLoggerProvider());

            return await optiondb.Domens.FirstOrDefaultAsync(t => t.Id == option.Id);
        }

        public async Task<IEnumerable<Domain>> GetEntitys()
        {
            optiondb.GetService<ILoggerFactory>().AddProvider(new MyLoggerProvider());

            return await optiondb.Domens.ToListAsync();
        }

        public Task<int> Update(Domain option)
        {
            throw new NotImplementedException();
        }
    }
}
