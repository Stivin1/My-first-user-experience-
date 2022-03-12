using static OpenSourceEnity.Models.Entities.AggreagateLogEntities.Entities.LoggingEnum;

namespace OpenSourceEnity.Models.Entities.AggreagateLogEntities.Entities
{
    //<summary>
    //Интерфейс предоставляющий методы логирования
    //</summary>
    interface ILogging
    {
        //<summary>
        //Метод отвечающий за формирование логирования пользователя
        ///<param name="user">Идентификатор пользователя.</param>
        ///<param name="LogInfo">Справочник логирования.</param>
        //</summary>
        Logging LoggingAttemptHome(string user, InformationLoggingEnum LogInfo);

        //<summary>
        //Метод отвечающий за формирование логирования пользователя
        ///<param name="user">Идентификатор пользователя.</param>
        ///<param name="LogInfo">Справочник логирования.</param>
        //</summary>
        Logging ViewingHome(string user, InformationLoggingEnum LogInfo);

        //<summary>
        //Метод отвечающий за формирование логирования пользователя
        ///<param name="user">Идентификатор пользователя.</param>
        ///<param name="LogInfo">Справочник логирования.</param>
        //</summary>
        Logging ListUser(string user, InformationLoggingEnum LogInfo);

        //<summary>
        //Метод отвечающий за формирование логирования пользователя
        ///<param name="user">Идентификатор пользователя.</param>
        ///<param name="LogInfo">Справочник логирования.</param>
        //</summary>
        Logging HomeViewParticipantUpdate(string user, InformationLoggingEnum LogInfo);

        //<summary>
        //Метод отвечающий за формирование логирования пользователя
        ///<param name="user">Идентификатор пользователя.</param>
        ///<param name="LogInfo">Справочник логирования.</param>
        //</summary>
        Logging HomeParticipantUpdate(string user, InformationLoggingEnum LogInfo);

        //<summary>
        //Метод отвечающий за формирование логирования пользователя
        ///<param name="user">Идентификатор пользователя.</param>
        ///<param name="LogInfo">Справочник логирования.</param>
        //</summary>
        Logging HomeViewUserApdate(string user, InformationLoggingEnum LogInfo);

        //<summary>
        //Метод отвечающий за формирование логирования пользователя
        ///<param name="user">Идентификатор пользователя.</param>
        ///<param name="LogInfo">Справочник логирования.</param>
        //</summary>
        Logging HomeUserApdate(string user, InformationLoggingEnum LogInfo);

        //<summary>
        //Метод отвечающий за формирование логирования пользователя
        ///<param name="user">Идентификатор пользователя.</param>
        ///<param name="LogInfo">Справочник логирования.</param>
        //</summary>
        Logging RoleViewAppend(string user, InformationLoggingEnum LogInfo);

        //<summary>
        //Метод отвечающий за формирование логирования пользователя
        ///<param name="user">Идентификатор пользователя.</param>
        ///<param name="LogInfo">Справочник логирования.</param>
        //</summary>
        Logging RoleAppend(string user, InformationLoggingEnum LogInfo);

        //<summary>
        //Метод отвечающий за формирование логирования пользователя
        ///<param name="user">Идентификатор пользователя.</param>
        ///<param name="LogInfo">Справочник логирования.</param>
        //</summary>
        Logging RoleViewUserAppend(string user, InformationLoggingEnum LogInfo);

        //<summary>
        //Метод отвечающий за формирование логирования пользователя
        ///<param name="user">Идентификатор пользователя.</param>
        ///<param name="LogInfo">Справочник логирования.</param>
        //</summary>
        Logging RoleUserAppend(string user, InformationLoggingEnum LogInfo);

        //<summary>
        //Метод отвечающий за формирование логирования пользователя
        ///<param name="user">Идентификатор пользователя.</param>
        ///<param name="LogInfo">Справочник логирования.</param>
        //</summary>
        Logging TeamViewAppend(string user, InformationLoggingEnum LogInfo);

        //<summary>
        //Метод отвечающий за формирование логирования пользователя
        ///<param name="user">Идентификатор пользователя.</param>
        ///<param name="LogInfo">Справочник логирования.</param>
        //</summary>
        Logging TeamAppend(string user, InformationLoggingEnum LogInfo);

        //<summary>
        //Метод отвечающий за формирование логирования пользователя
        ///<param name="user">Идентификатор пользователя.</param>
        ///<param name="LogInfo">Справочник логирования.</param>
        //</summary>
        Logging TeamViewUserAppned(string user, InformationLoggingEnum LogInfo);

        //<summary>
        //Метод отвечающий за формирование логирования пользователя
        ///<param name="user">Идентификатор пользователя.</param>
        ///<param name="LogInfo">Справочник логирования.</param>
        //</summary>
        Logging TeamUserAppned(string user, InformationLoggingEnum LogInfo);

        //<summary>
        //Метод отвечающий за формирование логирования пользователя
        ///<param name="user">Идентификатор пользователя.</param>
        ///<param name="LogInfo">Справочник логирования.</param>
        //</summary>
        Logging UserListMessageViewAppned(string user, InformationLoggingEnum LogInfo);

        //<summary>
        //Метод отвечающий за просмотр страницы отправки сообщения 
        ///<param name="user">Идентификатор пользователя.</param>
        ///<param name="LogInfo">Справочник логирования.</param>
        //</summary>
        Logging UserMessageView(string user, InformationLoggingEnum LogInfo);

        //<summary>
        //Метод отвечающий за просмотр страницы полученных сообщений
        ///<param name="user">Идентификатор пользователя.</param>
        ///<param name="LogInfo">Справочник логирования.</param>
        //</summary>
        Logging ReceivingViewMessage(string user, InformationLoggingEnum LogInfo);

        //<summary>
        //Метод отвечающий за просмотр открытие сообщения
        ///<param name="user">Идентификатор пользователя.</param>
        ///<param name="LogInfo">Справочник логирования.</param>
        //</summary>
        Logging ReceivingMessage(string user, InformationLoggingEnum LogInfo);
    }
}
