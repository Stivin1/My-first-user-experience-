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
    public class RepositoryTeam : IRepositoryTeam
    {
        //<summary>
        //Свойство для работы с источником данных
        //</summary>
        private ApplicationEnityContextdb optiondb { get; set; }

        //<summary>
        //Конструктор предоставляющий инициализацию параметров: 
        ///<param name="optiondb">Свой предоставляющее доступ к базе данных.</param>
        //</summary>
        public RepositoryTeam(ApplicationEnityContextdb optiondb)
        {
            this.optiondb = optiondb;
        }

        //<summary>
        //Метод отвечающий за добавление группы
        ///<param name="option">Ссылка на группу.</param>
        //</summary>
        public async Task<int> Create(Team option)
        {
            optiondb.GetService<ILoggerFactory>().AddProvider(new MyLoggerProvider());

            if (option == null) throw new Exception();

            await optiondb.Teams.AddAsync(option);
            await optiondb.SaveChangesAsync();

            return 1;
        }

        //<summary>
        //Метод отвечающий за удаление группы
        ///<param name="option">Ссылка на группу.</param>
        //</summary>
        public async Task<int> Delete(Team option)
        {
            optiondb.GetService<ILoggerFactory>().AddProvider(new MyLoggerProvider());

            var result = await optiondb.Teams.FirstOrDefaultAsync(t => t.id == option.id);

            optiondb.Remove(result);
            await optiondb.SaveChangesAsync();

            return 1;
        }

        //<summary>
        //Метод предоставляющий данные о группе
        ///<param name="option">Ссылка на группу.</param>
        //</summary>
        public async Task<Team> GetEntity(Team option)
        {
            optiondb.GetService<ILoggerFactory>().AddProvider(new MyLoggerProvider());

            return await optiondb.Teams.FirstOrDefaultAsync(t => t.id == option.id);
        }

        //<summary>
        //Метод отвечающий за вывод списка всех групп
        ///<param name=""></param>
        //</summary>
        public async Task<IEnumerable<Team>> GetEntitys()
        {
            return await optiondb.Teams.ToListAsync();
        }

        //<summary>
        //Метод отвечающий за обновление данных группы
        ///<param name="option">Ссылка на группу.</param>
        //</summary>
        public async Task<int> Update(Team option)
        {
            optiondb.GetService<ILoggerFactory>().AddProvider(new MyLoggerProvider());

            var result = await optiondb.Teams.FirstOrDefaultAsync(t => t.id == option.id);

            optiondb.Update(result);
            await optiondb.SaveChangesAsync();

            return 1;
        }

        //<summary>
        //Метод отвечающий за добавление группы пользователю 
        ///<param name="Users">Ссылка на пользователя.</param>
        ///<param name="Teams">Массив группы.</param>
        //</summary>
        public async Task<int> AddTeamsEntitys(User Users, IEnumerable<string> Teams)
        {
            optiondb.GetService<ILoggerFactory>().AddProvider(new MyLoggerProvider());

            var teamsIdentity = await optiondb.Teams.ToListAsync();

            foreach(var list in teamsIdentity)
            {
                foreach(var list1 in Teams)
                {
                    if(list1 == list.Name)
                    {
                        Users.Teams.Add(list);
                    }
                }
            }

            await optiondb.SaveChangesAsync();

            return 1;

        }

        //<summary>
        //Метод отвечающий за удаление группы пользователя 
        ///<param name="Users">Ссылка на пользователя.</param>
        ///<param name="Teams">Массив группы.</param>
        //</summary>
        public async Task<int> RemoveTeamsEntitys(User Users, IEnumerable<string> Teams)
        {
            optiondb.GetService<ILoggerFactory>().AddProvider(new MyLoggerProvider());

            var teamsIdentity = await optiondb.Teams.ToListAsync();

            foreach (var list in teamsIdentity)
            {
                foreach (var list1 in Teams)
                {
                    if (list1 == list.Name)
                    {
                        Users.Teams.Remove(list);
                    }
                }
            }

            await optiondb.SaveChangesAsync();

            return 1;
        }

        //<summary>
        //Метод отвечающий за вывод списка группы пользователя
        ///<param name="UserId">Ссылка на пользователя.</param>
        //</summary>
        public async Task<List<string>> GetEntitys(string UserId)
        {
            optiondb.GetService<ILoggerFactory>().AddProvider(new MyLoggerProvider());

            var userteams = await optiondb.Teams.Include(t => t.Users).ToListAsync();

            List<string> result = new List<string>();

            foreach (var list in userteams)
            {
                foreach (var list1 in list.Users)
                {
                    if (list1.Id == UserId) result.Add(list.Name);
                }
            }

            return result;
        }
    }
}
