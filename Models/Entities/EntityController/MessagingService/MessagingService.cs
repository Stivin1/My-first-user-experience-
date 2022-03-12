using Microsoft.EntityFrameworkCore;
using OpenSourceEnity.Models.ContextDb;
using OpenSourceEnity.Models.ControllerEntitiesHelpers.MessagingService;
using OpenSourceEnity.Models.Entities.EntityController;
using OpenSourceEnity.Models.Entities.SystemEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenSourceEnity.Models.ControllerEntitiesHelpers.MessageService
{
    //<summary>
    //Класс сервис по работе с сообщениями
    //</summary>
    public class MessagingService : IMessagingService , IMessageRegService
    {
        //<summary>
        //Свойство для работы с источником данных
        //</summary>
        private ApplicationEnityContextdb contextdb;

        //<summary>
        //Конструктор предоставляющий инициализацию параметров: 
        ///<param name="ApplicationEnityContextdb">Свой предоставляющее доступ к базе данных</param>
        //</summary>
        public MessagingService(ApplicationEnityContextdb contextdb)
        {
            this.contextdb = contextdb;
        }

        //<summary>
        //Метод отвечающий за формирование и добавление сообщения
        ///<param name="UserId">Идентификатор пользователя</param>
        ///<param name="UserIdRecipient">Идентификатор получателя сообщения</param>
        ///<param name="Theme">Тема сообщения</param>
        ///<param name="Text">Текст сообщения</param>
        //</summary>
        public async Task<int> SendMessageService(string UserId, string UserIdRecipient, string Theme, string Text)
        {
            try
            {
                var theme = GetThemeMessage(Theme, t => { return t; });

                var message = GetMessage(Text, theme, t => { return t; });

                var addressee = GetAddresseeMessage(UserId, UserIdRecipient, message, t => { return t; });

                await contextdb.ThemeMessages.AddAsync(theme);

                await contextdb.Messages.AddAsync(message);

                await contextdb.AddresseeMessages.AddAsync(addressee);

                await contextdb.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error SendMessageService sending forming message: " + ex.Message);
            }

            return 1;
        }

        //<summary>
        //Метод формирущий тему сообщения
        ///<param name="Theme">Тема сообщения</param>
        ///<param name="func">Функция возвращающая тему сообщения</param>
        //</summary>
        private ThemeMessage GetThemeMessage(string Theme, Func<ThemeMessage, ThemeMessage> func)
        {
            if (string.IsNullOrEmpty(Theme)) throw new ArgumentNullException("Error GetThemeMessage forming theme message");

            return new ThemeMessage
            {
                Theme = Theme
            };

        }

        //<summary>
        //Метод формирущий тему сообщения
        ///<param name="Text">Текст сообщения</param>
        ///<param name="ThemeMessage">Ссылка на тему сообщения</param>
        ///<param name="func">Функция возвращающая сформированное сообщени</param>
        //</summary>
        private Message GetMessage(string Text, ThemeMessage ThemeMessage, Func<Message, Message> func)
        {
            if (string.IsNullOrEmpty(Text) || ThemeMessage == null) throw new ArgumentNullException("Error GetMessage forming message");

            return new Message
            {
                Text = Text,
                ThemeMessage = ThemeMessage,
                DataCreate = DateTime.Now.ToString()
            };

        }

        //<summary>
        //Метод формирущий тему сообщения
        ///<param name="UserId">Идентификатор пользователя отправителя</param>
        ///<param name="UserIdRecipient">Идентификатор пользователя получателя</param>
        ///<param name="Message">Ссылка на сообщение</param>
        ///<param name="func">Функция возвращающая адрес отправки сообщения</param>
        //</summary>
        private AddresseeMessage GetAddresseeMessage(string UserId, string UserIdRecipient, Message Message, Func<AddresseeMessage, AddresseeMessage> func)
        {
            if (Message == null) throw new ArgumentNullException("Error GetAddresseeMessage forming address message");

            return new AddresseeMessage
            {
                Message = Message,
                UserId = UserId,
                RecipientId = UserIdRecipient,
            };

        }

        //<summary>
        //Метод отвечающий за вывод всех полученных сообещний пользователю
        ///<param name="UserId">Идентификатор пользователя отправителя</param>
        //</summary>
        public IEnumerable<AddresseeMessage> ListReadingMessageService(string UserId)
        {
            var Message = contextdb.AddresseeMessages.Include(t => t.User)
                .ThenInclude(t => t.Participant).Include(t => t.Message).Where(t => t.UserId == UserId || t.RecipientId == UserId).OrderByDescending(t => t.Message.DataCreate);
            
            return Message;
        }

        //<summary>
        //Метод формирущий тему сообщения
        ///<param name="MessageId">Идентификатор сообщения</param>
        //</summary>
        public async Task<AddresseeMessage> GetReadMessageAsync(int? MessageId)
        {
            try
            {
                return await GetMessageAsync(MessageId);
            }
            catch(Exception mes)
            {
                throw new Exception(mes.Message);
            }
        }

        //<summary>
        //Метод выводящий полученное сообщение пользователю
        ///<param name="MessageId">Идентификатор сообщения</param>
        //</summary>
        private async Task<AddresseeMessage> GetMessageAsync(int? MessageId)
        {
            if (MessageId == 0 || MessageId == null) throw new Exception("Error GetMessageAsync = null or 0");

            var message = await contextdb.AddresseeMessages.Include(t => t.Message)
                .ThenInclude(t => t.ThemeMessage).FirstOrDefaultAsync(t => t.MessageId == MessageId);

            return message;
        }

        //<summary>
        //Метод направляющий системное сообщение после регистрации пользователя
        ///<param name="user">Ссылка на пользователя</param>
        //</summary>
        public async Task<int> RegistrationInformation(User user)
        {
            if(string.IsNullOrEmpty(user.Email)) throw new Exception(string.Format("Error RegistrationInformation message to user = {0}", user.Email));

            await SendMessageService(contextdb.Users.FirstOrDefault(t => t.Email == "Bot@bk.ru").Id, user.Id,
                "Системное сообщение", "Добро пожаловать в OpenSource");

            return 1; 
        }

        //<summary>
        //Метод направляющий системное сообщение после внесения изменений данных участника
        ///<param name="user">Ссылка на пользователя</param>
        //</summary>
        public async Task<int> UpdateParticipantInformation(User user)
        {
            if (string.IsNullOrEmpty(user.Email)) throw new Exception(string.Format("Error UpdateParticipantInformation message to user = {0}", user.Email));

            await SendMessageService(contextdb.Users.FirstOrDefault(t => t.Email == "Bot@bk.ru").Id, user.Id,
                "Системное сообщение", string.Format("Ваши данные участника были изменены"));

            return 1;
        }

        //<summary>
        //Метод направляющий системное сообщение после внесения изменений данных пользователя
        ///<param name="user">Ссылка на пользователя</param>
        //</summary>
        public async Task<int> UpdateUserInformation(User user)
        {
            if (string.IsNullOrEmpty(user.Email)) throw new Exception(string.Format("Error UpdateParticipantInformation message to user = {0}", user.Email));

            await SendMessageService(contextdb.Users.FirstOrDefault(t => t.Email == "Bot@bk.ru").Id, user.Id,
                "Системное сообщение", string.Format("Ваши данные пользователя были изменены"));

            return 1;
        }
    }
}
