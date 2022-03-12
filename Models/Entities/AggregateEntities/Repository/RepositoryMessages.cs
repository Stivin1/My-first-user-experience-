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
    public class RepositoryMessages : IRepositoryMessages
    {
        private ApplicationEnityContextdb optiondb { get; set; }

        //<summary>
        //Конструктор предоставляющий инициализацию параметров: 
        ///<param name="optiondb">Свой предоставляющее доступ к базе данных.</param>
        //</summary>
        public RepositoryMessages(ApplicationEnityContextdb optiondb)
        {
            this.optiondb = optiondb;
        }

        //<summary>
        //Метод отвечающий за добавления сообщения
        ///<param name="option">Ссылка на сообщение.</param>
        //</summary>
        public async Task<int> Create(Message option)
        {
            optiondb.GetService<ILoggerFactory>().AddProvider(new MyLoggerProvider());

            await optiondb.Messages.AddAsync(option);
            await optiondb.SaveChangesAsync();

            return 1;
        }

        //<summary>
        //Метод отвечающий за удаления сообщения
        ///<param name="option">Ссылка на сообщение.</param>
        //</summary>
        public async Task<int> Delete(Message option)
        {
            optiondb.GetService<ILoggerFactory>().AddProvider(new MyLoggerProvider());

            var result = await optiondb.Messages.FirstOrDefaultAsync(t => t.id == option.id);

            optiondb.Remove(result);
            await optiondb.SaveChangesAsync();

            return 1;
        }

        //<summary>
        //Метод отвечающий за поиск сообщения
        ///<param name="option">Ссылка на сообщение.</param>
        //</summary>
        public async Task<Message> GetEntity(Message option)
        {
            optiondb.GetService<ILoggerFactory>().AddProvider(new MyLoggerProvider());

            return await optiondb.Messages.FirstOrDefaultAsync(t => t.id == option.id);
        }

        //<summary>
        //Метод отвечающий за вывод списка сообщений
        ///<param name="option">Ссылка на сообщение.</param>
        //</summary>
        public async Task<IEnumerable<Message>> GetEntitys()
        {
            optiondb.GetService<ILoggerFactory>().AddProvider(new MyLoggerProvider());

            return await optiondb.Messages.ToListAsync();
        }

        //<summary>
        //Метод отвечающий за обновление сообщения
        ///<param name="option">Ссылка на сообщение.</param>
        //</summary>
        public async Task<int> Update(Message option)
        {
            optiondb.GetService<ILoggerFactory>().AddProvider(new MyLoggerProvider());

            var result = await optiondb.Messages.FirstOrDefaultAsync(t => t.id == option.id);

            optiondb.Update(result);
            await optiondb.SaveChangesAsync();

            return 1;
        }
    }
}
