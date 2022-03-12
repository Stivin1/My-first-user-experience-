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
    //<summary>
    //Класс репозитория предоставляющий набор метод для работы с конкртным источником данных
    //</summary>
    public class RepositoryParticipant_AUD : IRepositoryParticipant_AUD
    {
        //<summary>
        //Свойство для работы с источником данных
        //</summary>
        private ApplicationEnityContextdb optiondb { get; set; }

        //<summary>
        //Конструктор предоставляющий инициализацию параметров: 
        ///<param name="optiondb">Свой предоставляющее доступ к базе данных.</param>
        //</summary>
        public RepositoryParticipant_AUD(ApplicationEnityContextdb optiondb)
        {
            this.optiondb = optiondb;
        }

        public async Task<int> Create(Participant_AUD option)
        {
            optiondb.GetService<ILoggerFactory>().AddProvider(new MyLoggerProvider());

            await optiondb.Participant_AUDs.AddAsync(option);
            await optiondb.SaveChangesAsync();

            return 1;
        }

        public async Task<int> Delete(Participant_AUD option)
        {
            throw new NotImplementedException();
        }

        public async Task<Participant_AUD> GetEntity(Participant_AUD option)
        {
            throw new NotImplementedException(); ;
        }

        public async Task<IEnumerable<Participant_AUD>> GetEntitys()
        {
            throw new NotImplementedException();
        }

        public async Task<int> Update(Participant_AUD option)
        {
            throw new NotImplementedException();
        }
    }
}
