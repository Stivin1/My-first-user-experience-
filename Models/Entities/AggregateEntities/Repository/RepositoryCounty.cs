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
    public class RepositoryCounty : IRepositoryCountry
    {
        //<summary>
        //Свойство для работы с источником данных
        //</summary>
        private ApplicationEnityContextdb optiondb { get; set; }

        //<summary>
        //Конструктор предоставляющий инициализацию параметров: 
        ///<param name="optiondb">Свой предоставляющее доступ к базе данных.</param>
        //</summary>
        public RepositoryCounty(ApplicationEnityContextdb optiondb)
        {
            this.optiondb = optiondb;
        }

        //<summary>
        //Метод отвечающий за добавления страны
        //</summary>
        public async Task<int> Create(Country option)
        {
            throw new NotImplementedException();
        }

        //<summary>
        //Метод отвечающий за удаление страны
        //</summary>
        public async Task<int> Delete(Country option)
        {
            throw new NotImplementedException();
        }

        //<summary>
        //Метод отвечающий за поиск конкретной страны
        ///<param name="option">Ссылка на страну.</param>
        //</summary>
        public async Task<Country> GetEntity(Country option)
        {
            return await optiondb.Countries.FindAsync(option);
        }

        //<summary>
        //Метод отвечающий за вывод списка страны
        ///<param name=""></param>
        //</summary>
        public async Task<IEnumerable<Country>> GetEntitys()
        {
            optiondb.GetService<ILoggerFactory>().AddProvider(new MyLoggerProvider());

            return await optiondb.Countries.ToListAsync();
        }

        //<summary>
        //Метод отвечающий за обновление наименования страны
        //</summary>
        public async Task<int> Update(Country option)
        {
            throw new NotImplementedException();
        }
    }
}
