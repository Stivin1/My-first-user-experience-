﻿using OpenSourceEnity.Models.ContextDb;
using OpenSourceEnity.Models.Entities.AggreagateLogEntities.Entities;
using OpenSourceEnity.Models.Entities.AggreagateLogEntities.IRepository;
using System.Threading.Tasks;
using static OpenSourceEnity.Models.Entities.AggreagateLogEntities.Entities.LoggingEnum;

namespace OpenSourceEnity.Models.Entities.AggreagateLogEntities.Repository
{
    //<summary>
    //Класс предоставляющий обработку логирования
    //</summary>
    public class RepositoryLogging : IRepositoryLogging
    {
        //<summary>
        //Свой предоставляющее доступ к базе данных
        //</summary>
        private ApplicationEnityContextdb optiondb { get; set; }

        //<summary>
        //Свойство предоставляющее за обработку логирования
        //</summary>
        public LoggingEnum loggingEnum { get; set; }

        //<summary>
        //Конструктор предоставляющий инициализацию параметров: 
        ///<param name="ApplicationEnityContextdb">Свой предоставляющее доступ к базе данных.</param>
        //</summary>
        public RepositoryLogging(ApplicationEnityContextdb optiondb)
        {
            this.optiondb = optiondb;
            loggingEnum = new LoggingEnum();
        }

        //<summary>
        //Метод отвечающий за обработку логирования пользователя и добавления лога в базу данных
        ///<param name="user">Идентификатор пользователя.</param>
        ///<param name="LogInfo">Справочник логирования.</param>
        //</summary>
        public async Task<int> InsertLog(string user, InformationLoggingEnum LogInfo)
        {
            var logging = loggingEnum.GetInformationLogging(optiondb.Users.Find(user).Id, LogInfo);

            await optiondb.Loggings.AddAsync(logging);
            await optiondb.SaveChangesAsync();

            return 1;
        }
    }
}
