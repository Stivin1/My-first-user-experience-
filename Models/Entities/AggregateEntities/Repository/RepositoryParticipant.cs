using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Logging;
using OpenSourceEnity.Models.ApplicationContextdb.ApplictionConnection.LogetContextdb;
using OpenSourceEnity.Models.ContextDb;
using OpenSourceEnity.Models.Entities.AggregateEntities.IRepository;
using OpenSourceEnity.Models.Entities.SystemEntities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenSourceEnity.Models.Entities.AggregateEntities.Repository
{
    //<summary>
    //Класс репозитория предоставляющий набор метод для работы с конкртным источником данных
    //</summary>
    public class RepositoryParticipant : IRepositoryParticipant
    {
        //<summary>
        //Свойство для работы с источником данных
        //</summary>
        private ApplicationEnityContextdb optiondb { get; set; }

        //<summary>
        //Конструктор предоставляющий инициализацию параметров: 
        ///<param name="optiondb">Свой предоставляющее доступ к базе данных.</param>
        //</summary>
        public RepositoryParticipant(ApplicationEnityContextdb optiondb)
        {
            this.optiondb = optiondb;
        }

        //<summary>
        //Метод отвечающий за добавления участника
        ///<param name="option">Ссылка на сообщение.</param>
        //</summary>
        public async Task<int> Create(Participant option)
        {
            optiondb.GetService<ILoggerFactory>().AddProvider(new MyLoggerProvider());

            await optiondb.Participants.AddAsync(option);
            await optiondb.SaveChangesAsync();

            return 1;
        }

        //<summary>
        //Метод отвечающий за удаление сообщения
        ///<param name="option">Ссылка на сообщение.</param>
        //</summary>
        public async Task<int> Delete(Participant option)
        {
            optiondb.GetService<ILoggerFactory>().AddProvider(new MyLoggerProvider());

            var result = await optiondb.Participants.FirstOrDefaultAsync(t => t.id == option.id);

            optiondb.Remove(result);
            await optiondb.SaveChangesAsync();

            return 1;
        }

        //<summary>
        //Метод отвечающий за вывод участников
        ///<param name="option">Ссылка на сообщение.</param>
        //</summary>
        public async Task<Participant> GetEntity(Participant option)
        {
            optiondb.GetService<ILoggerFactory>().AddProvider(new MyLoggerProvider());

            return await optiondb.Participants.FindAsync(option);
        }

        //<summary>
        //Метод отвечающий за вывод списка участников
        ///<param name="option">Ссылка на сообщение.</param>
        //</summary>
        public async Task<IEnumerable<Participant>> GetEntitys()
        {
            optiondb.GetService<ILoggerFactory>().AddProvider(new MyLoggerProvider());

            return await optiondb.Participants.ToListAsync();
        }

        //<summary>
        //Метод отвечающий за изменения данных участника
        ///<param name="option">Ссылка на сообщение.</param>
        //</summary>
        public async Task<int> Update(Participant option)
        {
            optiondb.GetService<ILoggerFactory>().AddProvider(new MyLoggerProvider());

            var result = await optiondb.Participants.FirstOrDefaultAsync(t => t.id == option.id);

            optiondb.Update(result);
            await optiondb.SaveChangesAsync();

            return 1;
        }
    }
}
