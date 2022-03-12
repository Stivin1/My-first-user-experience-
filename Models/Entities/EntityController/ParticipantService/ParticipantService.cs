using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OpenSourceEnity.Models.ContextDb;
using OpenSourceEnity.Models.ControllerEntitiesHelpers.MessageService;
using OpenSourceEnity.Models.Entities.AggreagateLogEntities.IUnitOfWork;
using OpenSourceEnity.Models.Entities.AggregateEntities.IRepository;
using OpenSourceEnity.Models.Entities.EntityController.ExtensionAgeMethods;
using OpenSourceEnity.Models.Entities.SystemEntities;
using OpenSourceEnity.Models.ModelViews.EntityViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenSourceEnity.Models.Entities.EntityController.ParticipantService
{
    //<summary>
    //Класс сервис отвечающий за обработку участника
    //</summary>
    public class ParticipantService
    {
        private IUnitOfWork UnitOfWork { get; set; }
        private ApplicationEnityContextdb contextdb { get; set; }
        private UserManager<User> UserManager { get; set; }
        private MessagingService MessagingService { get; set; }

        public ParticipantService(
            ApplicationEnityContextdb contextdb,
            UserManager<User> UserManager,
            IUnitOfWork UnitOfWork
            )
        {
            this.contextdb = contextdb;
            this.UserManager = UserManager;
            this.UnitOfWork = UnitOfWork;

            MessagingService = new MessagingService(contextdb);
        }

        //<summary>
        //Метод отвечающий за формирования участника
        ///<param name="registration">Ссылка на форму регистрации</param>
        ///<param name="user">Ссылка на пользователя</param>
        //</summary>
        public Participant GetParticipantMapper(Registration registration, User user)
        {
            Participant participant = new Participant
            {
                Name = registration.Name,
                MiddleName = registration.MiddleName,
                LastName = registration.LastName,
                DateAge = registration.DateAge,
                UserId = user.Id,
                PolId = registration.PolId,
                CountryId = registration.CountryId
            };

            return participant;
        }

        //<summary>
        //Метод отвечающий за обновление участника
        ///<param name="UpdateParticipant">Ссылка на форму обновления данных участника</param>
        //</summary>
        public async Task<int> GetUpdateParticipant(UpdateParticipant updateParticipant)
        {
            var user = await UserManager.FindByIdAsync(updateParticipant.UserId);
            var participant = contextdb.Participants.FirstOrDefaultAsync(t => t.UserId == updateParticipant.UserId).Result;

            participant.id = participant.id;
            participant.Name = updateParticipant.Name;
            participant.MiddleName = updateParticipant.MiddleName;
            participant.LastName = updateParticipant.LastName;
            participant.DateAge = updateParticipant.DateAge;
            participant.Name = updateParticipant.Name;
            participant.CountryId = updateParticipant.CountryId;
            participant.PolId = updateParticipant.PolId;

            user.Age = updateParticipant.DateAge.UserAge();
            user.DateChanges = DateTime.Now.ToString();

            await UserManager.UpdateAsync(user);
            await UnitOfWork.RepositoryParticipant.Update(participant);

            await SetParticipantAUD(participant);

            var user_message = await UserManager.FindByIdAsync(updateParticipant.UserId);
            await MessagingService.UpdateParticipantInformation(user_message);

            return 1;
        }

        private async Task<int> SetParticipantAUD(Participant participant)
        {
            Participant_AUD participant_AUD = new Participant_AUD
            {
                ParticipantId = participant.id,
                UserId = participant.UserId,
                Name = participant.Name,
                MiddleName = participant.MiddleName,
                LastName = participant.LastName,
                DateAge = participant.DateAge,
                CountryId = participant.CountryId,
                PolId = participant.PolId
            };

           return await UnitOfWork.IRepositoryParticipant_AUD.Create(participant_AUD);
        }
    }
}
