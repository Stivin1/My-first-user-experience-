using OpenSourceEnity.Models.Entities.SystemEntities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenSourceEnity.Models.ControllerEntitiesHelpers.MessagingService
{
    //<summary>
    //Интерфейс предоставляющий функционал для работы с сообщениями
    //</summary>
    interface IMessagingService
    {
        //<summary>
        //Метод отвечающий за формирование и добавление сообщения
        ///<param name="UserId">Идентификатор пользователя</param>
        ///<param name="UserIdRecipient">Идентификатор получателя сообщения</param>
        ///<param name="Theme">Тема сообщения</param>
        ///<param name="Text">Текст сообщения</param>
        //</summary>
        Task<int> SendMessageService(string UserId, string UserIdRecipient, string ThemeMessage, string Text);

        //<summary>
        //Метод отвечающий за вывод всех полученных сообещний пользователю
        ///<param name="UserId">Идентификатор пользователя отправителя</param>
        //</summary>
        IEnumerable<AddresseeMessage> ListReadingMessageService(string UserId);

        //<summary>
        //Метод формирущий тему сообщения
        ///<param name="MessageId">Идентификатор сообщения</param>
        //</summary>
        Task<AddresseeMessage> GetReadMessageAsync(int? MessageId);
    }
}
