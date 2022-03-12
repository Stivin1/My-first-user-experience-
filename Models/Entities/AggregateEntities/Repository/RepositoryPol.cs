using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Logging;
using OpenSourceEnity.Models.ApplicationContextdb.ApplictionConnection.LogetContextdb;
using OpenSourceEnity.Models.ContextDb;
using OpenSourceEnity.Models.Entities.AggregateEntities.IRepository;
using OpenSourceEnity.Models.Entities.SystemEntities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenSourceEnity.Models.Entities.AggregateEntities.Repository
{
    //<summary>
    //Класс репозитория предоставляющий набор метод для работы с конкртным источником данных
    //</summary>
    public class RepositoryPol : IRepositoryPol
    {
        //<summary>
        //Свойство для работы с источником данных
        //</summary>
        private ApplicationEnityContextdb optiondb { get; set; }

        //<summary>
        //Конструктор предоставляющий инициализацию параметров: 
        ///<param name="optiondb">Свой предоставляющее доступ к базе данных.</param>
        //</summary>
        public RepositoryPol(ApplicationEnityContextdb optiondb)
        {
            this.optiondb = optiondb;
        }

        //<summary>
        //Метод отвечающий за добавления пола
        //</summary>
        public async Task<int> Create(Pol option)
        {
            throw new NotImplementedException();
        }

        //<summary>
        //Метод отвечающий за удаление пола
        //</summary>
        public async Task<int> Delete(Pol option)
        {
            throw new NotImplementedException();
        }

        //<summary>
        //Метод отвечающий за вывод данных пола
        ///<param name="option">Ссылка на пол.</param>
        //</summary>
        public async Task<Pol> GetEntity(Pol option)
        {
            optiondb.GetService<ILoggerFactory>().AddProvider(new MyLoggerProvider());

            return await optiondb.Pols.FirstOrDefaultAsync(t => t.id == option.id);
        }

        //<summary>
        //Метод отвечающий за вывод списка справочника пола
        ///<param name=""></param>
        //</summary>
        public async Task<IEnumerable<Pol>> GetEntitys()
        {
            optiondb.GetService<ILoggerFactory>().AddProvider(new MyLoggerProvider());

            return await optiondb.Pols.ToListAsync();
        }

        //<summary>
        //Метод отвечающий за обновление данных пола
        ///<param name="option">Ссылка на пол.</param>
        //</summary>
        public async Task<int> Update(Pol option)
        {
            throw new NotImplementedException();
        }
    }
}
