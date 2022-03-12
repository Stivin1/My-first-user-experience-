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
    public class RepositoryThemeMessages : IRepositoryThemeMessages
    {
        //<summary>
        //Свойство для работы с источником данных
        //</summary>
        private ApplicationEnityContextdb optiondb { get; set; }

        //<summary>
        //Конструктор предоставляющий инициализацию параметров: 
        ///<param name="optiondb">Свой предоставляющее доступ к базе данных.</param>
        //</summary>
        public RepositoryThemeMessages(ApplicationEnityContextdb optiondb)
        {
            this.optiondb = optiondb;
        }

        //<summary>
        //Метод отвечающий за добавление данных темы сообщения
        ///<param name="option">Ссылка на группу.</param>
        //</summary>
        public async Task<int> Create(ThemeMessage option)
        {
            optiondb.GetService<ILoggerFactory>().AddProvider(new MyLoggerProvider());

            await optiondb.ThemeMessages.AddAsync(option);
            await optiondb.SaveChangesAsync();

            return 1;
        }

        //<summary>
        //Метод отвечающий за удаление данных темы сообщения
        ///<param name="option">Ссылка на группу.</param>
        //</summary>
        public async Task<int> Delete(ThemeMessage option)
        {
            optiondb.GetService<ILoggerFactory>().AddProvider(new MyLoggerProvider());

            var result = await optiondb.ThemeMessages.FirstOrDefaultAsync(t => t.id == option.id); 

            optiondb.Remove(result);
            await optiondb.SaveChangesAsync();

            return 1;
        }

        //<summary>
        //Метод отвечающий за вывод данных темы
        ///<param name="option">Ссылка на группу.</param>
        //</summary>
        public async Task<ThemeMessage> GetEntity(ThemeMessage option)
        {
            optiondb.GetService<ILoggerFactory>().AddProvider(new MyLoggerProvider());

            return await optiondb.ThemeMessages.FirstOrDefaultAsync(t => t.id == option.id);
        }

        //<summary>
        //Метод отвечающий за вывод списка тем
        ///<param name="option">Ссылка на группу.</param>
        //</summary>
        public async Task<IEnumerable<ThemeMessage>> GetEntitys()
        {
            optiondb.GetService<ILoggerFactory>().AddProvider(new MyLoggerProvider());

            return await optiondb.ThemeMessages.ToListAsync();
        }

        //<summary>
        //Метод отвечающий за обновление темы 
        ///<param name="option">Ссылка на группу.</param>
        //</summary>
        public async Task<int> Update(ThemeMessage option)
        {
            optiondb.GetService<ILoggerFactory>().AddProvider(new MyLoggerProvider());

            var result = await optiondb.ThemeMessages.FirstOrDefaultAsync(t => t.id == option.id);

            optiondb.Update(result);
            await optiondb.SaveChangesAsync();

            return 1;
        }
    }
}
