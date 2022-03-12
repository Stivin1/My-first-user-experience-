using System;

namespace OpenSourceEnity.Models.Entities.AggreagateLogEntities.Entities
{
    //<summary>
    //Системная сущность логирования
    //<s/ummary>
    public class LoggingEnum : ILogging
    {
        //<summary>
        //Список логирования
        //<summary>
        public enum InformationLoggingEnum
        {
            //<summary>
            // Попытка входа
            //</summary>
            AttemptHome = 1,

            //<summary>
            // Просмот главной страницы
            //<s/ummary>
            ViewingHome = 2,

            //<summary>
            // Просмотр пользователей
            //</summary>
            ListUser = 3,

            //<summary>
            // Просмотр страницы обновления данных участника
            //</summary>
            HomeViewParticipantUpdate = 4,

            //<summary>
            // Обновление данных участника
            //</summary>
            HomeParticipantUpdate = 5,

            //<summary>
            // Просмотр страницы обновления данных пользователя
            //</summary>
            HomeViewUserApdate = 6,

            //<summary>
            // Обновление данных пользователя
            //</summary>
            HomeUserApdate = 7,

            //<summary>
            // Просмотр страница добавления роли
            //</summary>
            RoleViewAppend = 8,

            //<summary>
            // Добавление роли
            //</summary>
            RoleAppend = 9,

            //<summary>
            // Просмотр страница добавления роли пользователю
            //</summary>
            RoleViewUserAppend = 10,

            //<summary>
            // Добавление роли пользователю 
            //</summary>
            RoleUserAppend = 11,

            //<summary>
            // Просмотр страницы добавления группы
            //</summary>
            TeamViewAppend = 12,

            //<summary>
            // Добавление группы
            //</summary>
            TeamAppend = 13,

            //<summary>
            // Просмотр страницы добавления группы пользователю
            //</summary>
            TeamViewUserAppned = 14,

            //<summary>
            // Добавление группы пользователю
            //</summary>
            TeamUserAppned = 15,

            //<summary>
            // Просмотр страницы списка пользователей для отправки сообщения
            //</summary>
            UserListMessageViewAppned = 16,

            //<summary>
            // Просмотр страницы отправки сообщения
            //</summary>
            UserMessageView = 17,

            //<summary>
            // Просмотр страницы полученных сообщений
            //</summary>
            ReceivingViewMessage = 18,

            //<summary>
            // Открытие сообщения
            //</summary>
            ReceivingMessage = 19

        }

        //<summary>
        //Метод отвечающий за обработку логирования пользователя и возвращающий объект логирования
        ///<param name="user">Идентификатор пользователя.</param>
        ///<param name="LogInfo">Справочник логирования.</param>
        //</summary>
        public Logging GetInformationLogging(string user,InformationLoggingEnum LogInfo)
        {
            return LogInfo switch
            {
                InformationLoggingEnum.AttemptHome => LoggingAttemptHome(user,InformationLoggingEnum.AttemptHome),
                InformationLoggingEnum.ViewingHome => ViewingHome(user, InformationLoggingEnum.ViewingHome),
                InformationLoggingEnum.ListUser => ListUser(user, InformationLoggingEnum.ListUser),
                InformationLoggingEnum.HomeViewParticipantUpdate => HomeViewParticipantUpdate(user, InformationLoggingEnum.HomeViewParticipantUpdate),
                InformationLoggingEnum.HomeParticipantUpdate => HomeParticipantUpdate(user, InformationLoggingEnum.HomeParticipantUpdate),
                InformationLoggingEnum.HomeViewUserApdate => HomeViewUserApdate(user, InformationLoggingEnum.HomeViewUserApdate),
                InformationLoggingEnum.HomeUserApdate => HomeUserApdate(user, InformationLoggingEnum.HomeUserApdate),
                InformationLoggingEnum.RoleViewAppend => RoleViewAppend(user, InformationLoggingEnum.RoleViewAppend),
                InformationLoggingEnum.RoleAppend => RoleAppend(user, InformationLoggingEnum.RoleAppend),
                InformationLoggingEnum.RoleViewUserAppend => RoleViewUserAppend(user, InformationLoggingEnum.RoleViewUserAppend),
                InformationLoggingEnum.RoleUserAppend => RoleUserAppend(user, InformationLoggingEnum.RoleUserAppend),
                InformationLoggingEnum.TeamViewAppend => TeamViewAppend(user, InformationLoggingEnum.TeamViewAppend),
                InformationLoggingEnum.TeamAppend => TeamAppend(user, InformationLoggingEnum.TeamAppend),
                InformationLoggingEnum.TeamViewUserAppned => TeamViewUserAppned(user, InformationLoggingEnum.TeamViewUserAppned),
                InformationLoggingEnum.TeamUserAppned => TeamUserAppned(user, InformationLoggingEnum.TeamUserAppned),
                InformationLoggingEnum.UserListMessageViewAppned => UserListMessageViewAppned(user, InformationLoggingEnum.TeamUserAppned),
                InformationLoggingEnum.UserMessageView => UserMessageView(user, InformationLoggingEnum.UserMessageView),
                InformationLoggingEnum.ReceivingViewMessage => ReceivingViewMessage(user, InformationLoggingEnum.ReceivingViewMessage),
                InformationLoggingEnum.ReceivingMessage => ReceivingMessage(user, InformationLoggingEnum.ReceivingMessage),
                _ => throw new Exception("Internal error recording user data stories")
            };
        }

        //<summary>
        //Метод отвечающий за формирование логирования пользователя
        ///<param name="user">Идентификатор пользователя.</param>
        ///<param name="LogInfo">Справочник логирования.</param>
        //</summary>
        public Logging LoggingAttemptHome(string user, InformationLoggingEnum LogInfo)
        {
            return new Logging
            {
                UserId = user,
                LoggingInformationId = (int)LogInfo,
                Description = "Попытка входа",
                DateCreate = DateTime.Now.ToString()
            };
        }

        //<summary>
        //Метод отвечающий за формирование логирования пользователя
        ///<param name="user">Идентификатор пользователя.</param>
        ///<param name="LogInfo">Справочник логирования.</param>
        //</summary>
        public Logging ViewingHome(string user, InformationLoggingEnum LogInfo)
        {
            return new Logging
            {
                UserId = user,
                LoggingInformationId = (int)LogInfo,
                Description = "Просмотр главной страницы",
                DateCreate = DateTime.Now.ToString()
            };
        }

        //<summary>
        //Метод отвечающий за формирование логирования пользователя
        ///<param name="user">Идентификатор пользователя.</param>
        ///<param name="LogInfo">Справочник логирования.</param>
        //</summary>
        public Logging ListUser(string user, InformationLoggingEnum LogInfo)
        {
            return new Logging
            {
                UserId = user,
                LoggingInformationId = (int)LogInfo,
                Description = "Просмотр пользователей",
                DateCreate = DateTime.Now.ToString()
            };
        }

        //<summary>
        //Метод отвечающий за формирование логирования пользователя
        ///<param name="user">Идентификатор пользователя.</param>
        ///<param name="LogInfo">Справочник логирования.</param>
        //</summary>
        public Logging HomeViewParticipantUpdate(string user, InformationLoggingEnum LogInfo)
        {
            return new Logging
            {
                UserId = user,
                LoggingInformationId = (int)LogInfo,
                Description = "Просмотр страницы обновления данных участника",
                DateCreate = DateTime.Now.ToString()
            };
        }

        //<summary>
        //Метод отвечающий за формирование логирования пользователя
        ///<param name="user">Идентификатор пользователя.</param>
        ///<param name="LogInfo">Справочник логирования.</param>
        //</summary>
        public Logging HomeParticipantUpdate(string user, InformationLoggingEnum LogInfo)
        {
            return new Logging
            {
                UserId = user,
                LoggingInformationId = (int)LogInfo,
                Description = "Обновление данных участника",
                DateCreate = DateTime.Now.ToString()
            };
        }

        //<summary>
        //Метод отвечающий за формирование логирования пользователя
        ///<param name="user">Идентификатор пользователя.</param>
        ///<param name="LogInfo">Справочник логирования.</param>
        //</summary>
        public Logging HomeViewUserApdate(string user, InformationLoggingEnum LogInfo)
        {
            return new Logging
            {
                UserId = user,
                LoggingInformationId = (int)LogInfo,
                Description = "Просмотр страницы обновления данных пользователя",
                DateCreate = DateTime.Now.ToString()
            };
        }

        //<summary>
        //Метод отвечающий за формирование логирования пользователя
        ///<param name="user">Идентификатор пользователя.</param>
        ///<param name="LogInfo">Справочник логирования.</param>
        //</summary>
        public Logging HomeUserApdate(string user, InformationLoggingEnum LogInfo)
        {
            return new Logging
            {
                UserId = user,
                LoggingInformationId = (int)LogInfo,
                Description = "Обновление данных пользователя",
                DateCreate = DateTime.Now.ToString()
            };
        }

        //<summary>
        //Метод отвечающий за формирование логирования пользователя
        ///<param name="user">Идентификатор пользователя.</param>
        ///<param name="LogInfo">Справочник логирования.</param>
        //</summary>
        public Logging RoleViewAppend(string user, InformationLoggingEnum LogInfo)
        {
            return new Logging
            {
                UserId = user,
                LoggingInformationId = (int)LogInfo,
                Description = "Просмотр страница добавления роли",
                DateCreate = DateTime.Now.ToString()
            };
        }

        //<summary>
        //Метод отвечающий за формирование логирования пользователя
        ///<param name="user">Идентификатор пользователя.</param>
        ///<param name="LogInfo">Справочник логирования.</param>
        //</summary>
        public Logging RoleAppend(string user, InformationLoggingEnum LogInfo)
        {
            return new Logging
            {
                UserId = user,
                LoggingInformationId = (int)LogInfo,
                Description = "Добавление роли",
                DateCreate = DateTime.Now.ToString()
            };
        }

        //<summary>
        //Метод отвечающий за формирование логирования пользователя
        ///<param name="user">Идентификатор пользователя.</param>
        ///<param name="LogInfo">Справочник логирования.</param>
        //</summary>
        public Logging RoleViewUserAppend(string user, InformationLoggingEnum LogInfo)
        {
            return new Logging
            {
                UserId = user,
                LoggingInformationId = (int)LogInfo,
                Description = "Просмотр страница добавления роли пользователю",
                DateCreate = DateTime.Now.ToString()
            };
        }

        //<summary>
        //Метод отвечающий за формирование логирования пользователя
        ///<param name="user">Идентификатор пользователя.</param>
        ///<param name="LogInfo">Справочник логирования.</param>
        //</summary>
        public Logging RoleUserAppend(string user, InformationLoggingEnum LogInfo)
        {
            return new Logging
            {
                UserId = user,
                LoggingInformationId = (int)LogInfo,
                Description = "Добавление роли пользователю",
                DateCreate = DateTime.Now.ToString()
            };
        }

        //<summary>
        //Метод отвечающий за формирование логирования пользователя
        ///<param name="user">Идентификатор пользователя.</param>
        ///<param name="LogInfo">Справочник логирования.</param>
        //</summary>
        public Logging TeamViewAppend(string user, InformationLoggingEnum LogInfo)
        {
            return new Logging
            {
                UserId = user,
                LoggingInformationId = (int)LogInfo,
                Description = "Просмотр страницы добавления группы",
                DateCreate = DateTime.Now.ToString()
            };
        }

        //<summary>
        //Метод отвечающий за формирование логирования пользователя
        ///<param name="user">Идентификатор пользователя.</param>
        ///<param name="LogInfo">Справочник логирования.</param>
        //</summary>
        public Logging TeamAppend(string user, InformationLoggingEnum LogInfo)
        {
            return new Logging
            {
                UserId = user,
                LoggingInformationId = (int)LogInfo,
                Description = "Добавление группы",
                DateCreate = DateTime.Now.ToString()
            };
        }

        //<summary>
        //Метод отвечающий за формирование логирования пользователя
        ///<param name="user">Идентификатор пользователя.</param>
        ///<param name="LogInfo">Справочник логирования.</param>
        //</summary>
        public Logging TeamViewUserAppned(string user, InformationLoggingEnum LogInfo)
        {
            return new Logging
            {
                UserId = user,
                LoggingInformationId = (int)LogInfo,
                Description = "Просмотр страницы добавления группы пользователю",
                DateCreate = DateTime.Now.ToString()
            };
        }

        //<summary>
        //Метод отвечающий за формирование логирования пользователя
        ///<param name="user">Идентификатор пользователя.</param>
        ///<param name="LogInfo">Справочник логирования.</param>
        //</summary>
        public Logging TeamUserAppned(string user, InformationLoggingEnum LogInfo)
        {
            return new Logging
            {
                UserId = user,
                LoggingInformationId = (int)LogInfo,
                Description = "Добавление группы пользователю",
                DateCreate = DateTime.Now.ToString()
            };
        }

        //<summary>
        //Метод отвечающий за формирование логирования пользователя
        ///<param name="user">Идентификатор пользователя.</param>
        ///<param name="LogInfo">Справочник логирования.</param>
        //</summary>
        public Logging UserListMessageViewAppned(string user, InformationLoggingEnum LogInfo)
        {
            return new Logging
            {
                UserId = user,
                LoggingInformationId = (int)LogInfo,
                Description = "Просмотр страницы отправки сообщения пользователям",
                DateCreate = DateTime.Now.ToString()
            };
        }

        //<summary>
        //Метод отвечающий за просмотр страницы отправки сообщения 
        ///<param name="user">Идентификатор пользователя.</param>
        ///<param name="LogInfo">Справочник логирования.</param>
        //</summary>
        public Logging UserMessageView(string user, InformationLoggingEnum LogInfo)
        {
            return new Logging
            {
                UserId = user,
                LoggingInformationId = (int)LogInfo,
                Description = "Просмотр страницы отправки сообщения",
                DateCreate = DateTime.Now.ToString()
            };
        }

        //<summary>
        //Метод отвечающий за просмотр страницы полученных сообщений
        ///<param name="user">Идентификатор пользователя.</param>
        ///<param name="LogInfo">Справочник логирования.</param>
        //</summary>
        public Logging ReceivingViewMessage(string user, InformationLoggingEnum LogInfo)
        {
            return new Logging
            {
                UserId = user,
                LoggingInformationId = (int)LogInfo,
                Description = "Просмотр страницы полученных сообщений",
                DateCreate = DateTime.Now.ToString()
            };
        }

        //<summary>
        //Метод отвечающий за просмотр открытие сообщения
        ///<param name="user">Идентификатор пользователя.</param>
        ///<param name="LogInfo">Справочник логирования.</param>
        //</summary>
        public Logging ReceivingMessage(string user, InformationLoggingEnum LogInfo)
        {
            return new Logging
            {
                UserId = user,
                LoggingInformationId = (int)LogInfo,
                Description = "Открытие полученного сообщения",
                DateCreate = DateTime.Now.ToString()
            };
        }
    }
}
