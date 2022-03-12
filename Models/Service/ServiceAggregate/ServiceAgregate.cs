using Microsoft.Extensions.DependencyInjection;
using OpenSourceEnity.Models.ControllerEntitiesHelpers.MessageService;
using OpenSourceEnity.Models.Entities.AggreagateLogEntities.IRepository;
using OpenSourceEnity.Models.Entities.AggreagateLogEntities.IUnitOfWork;
using OpenSourceEnity.Models.Entities.AggreagateLogEntities.Repository;
using OpenSourceEnity.Models.Entities.AggreagateLogEntities.UnitLogOfWork;
using OpenSourceEnity.Models.Entities.AggregateEntities.IRepository;
using OpenSourceEnity.Models.Entities.AggregateEntities.Repository;
using OpenSourceEnity.Models.Entities.AggregateEntities.UnitOfWork;
using OpenSourceEnity.Models.Entities.EntityController.ClaimsService;
using OpenSourceEnity.Models.Entities.EntityController.ParticipantService;
using OpenSourceEnity.Models.Entities.EntityController.UserService;

namespace OpenSourceEnity.Models.Service.ServiceAggregate
{
    public static class ServiceAgregate
    {
        public static IServiceCollection AddServiceAgregate(this IServiceCollection services)
        {
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IUnitLogOfWork, UnitLogOfWork>();
            services.AddTransient<IRepositoryLogging, RepositoryLogging>();
            services.AddTransient<IRepositoryTeam, RepositoryTeam>();
            services.AddTransient<IRepositoryParticipant, RepositoryParticipant>();
            services.AddTransient<IRepositoryParticipant_AUD, RepositoryParticipant_AUD>();
            services.AddTransient<IRepositoryCountry, RepositoryCounty>();
            services.AddTransient<IRepositoryPol, RepositoryPol>();
            services.AddTransient<IRepositoryThemeMessages, RepositoryThemeMessages>();
            services.AddTransient<IRepositoryMessages, RepositoryMessages>();
            services.AddTransient<IRepositoryDomain, RepositoryDomain>();
            services.AddTransient<UserService>();
            services.AddTransient<ParticipantService>();
            services.AddTransient<MessagingService>();
            services.AddTransient<ClaimService>();

            return services;
        }
    }
}
