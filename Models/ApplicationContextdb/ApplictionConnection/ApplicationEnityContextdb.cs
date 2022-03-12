using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using OpenSourceEnity.Models.ApplicationContextdb.AddresseeConfiguration;
using OpenSourceEnity.Models.ApplicationContextdb.ApplictionConnection.LogetContextdb;
using OpenSourceEnity.Models.ApplicationContextdb.CountryAppConfiguration;
using OpenSourceEnity.Models.ApplicationContextdb.DomenAppConfiguration;
using OpenSourceEnity.Models.ApplicationContextdb.LoggingAppConfiguration;
using OpenSourceEnity.Models.ApplicationContextdb.MessageConfiguration;
using OpenSourceEnity.Models.ApplicationContextdb.ParticipantAppConfiguration;
using OpenSourceEnity.Models.ApplicationContextdb.ParticipantAudAppConfiguration;
using OpenSourceEnity.Models.ApplicationContextdb.PolAppConfiguration;
using OpenSourceEnity.Models.ApplicationContextdb.TeamAppConfiguration;
using OpenSourceEnity.Models.ApplicationContextdb.ThemeMessageConfiguration;
using OpenSourceEnity.Models.ApplicationContextdb.UserAppConfiguration;
using OpenSourceEnity.Models.Entities.AggreagateLogEntities.Entities;
using OpenSourceEnity.Models.Entities.SystemEntities;

namespace OpenSourceEnity.Models.ContextDb
{
    public class ApplicationEnityContextdb : IdentityDbContext<User>
    {
        public DbSet<Participant> Participants { get; set; }
        public DbSet<Pol> Pols { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Logging> Loggings { get; set; }
        public DbSet<ThemeMessage> ThemeMessages { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<AddresseeMessage> AddresseeMessages { get; set; }
        public DbSet<Domain> Domens { get; set; }
        public DbSet<Participant_AUD> Participant_AUDs { get; set; }

        public ApplicationEnityContextdb(DbContextOptions<ApplicationEnityContextdb> options) : base(options)
        {
            Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new UserAppConfigurationBuilder());
            modelBuilder.ApplyConfiguration(new ParticipantAppConfigurationBuilder());
            modelBuilder.ApplyConfiguration(new ParticipantAudAppConfigurationBuilder());
            modelBuilder.ApplyConfiguration(new PolAppConfigurationBuilder());
            modelBuilder.ApplyConfiguration(new CountryAppConfigurationBuilder());
            modelBuilder.ApplyConfiguration(new TeamAppConfigurationBuilder());
            modelBuilder.ApplyConfiguration(new LoggingAppConfigurationBuilder());
            modelBuilder.ApplyConfiguration(new ThemeMessageAppConfigurationBuilder());
            modelBuilder.ApplyConfiguration(new MessageAppConfigurationBuilder());
            modelBuilder.ApplyConfiguration(new AddresseeMessageAppConfigurationBuilder());
            modelBuilder.ApplyConfiguration(new DomainAppConfiguration());

            modelBuilder.Entity<LoggingInformation>().HasData(new LoggingInformation[]
            {
                new LoggingInformation { id = 1, Name = "Попытка входа" },
                new LoggingInformation { id = 2, Name = "Просмот главной страниц" },
                new LoggingInformation { id = 3, Name = "Просмотр пользователей" },
                new LoggingInformation { id = 4, Name = "Просмотр страницы обновления данных участника" },
                new LoggingInformation { id = 5, Name = "Обновление данных участника" },
                new LoggingInformation { id = 6, Name = "Просмотр страницы обновления данных пользователя" },
                new LoggingInformation { id = 7, Name = "Обновление данных пользователя" },
                new LoggingInformation { id = 8, Name = "Просмотр страница добавления роли" },
                new LoggingInformation { id = 9, Name = "Добавление роли" },
                new LoggingInformation { id = 10, Name = "Просмотр страница добавления роли пользователю" },
                new LoggingInformation { id = 11, Name = "Добавление роли пользователю" },
                new LoggingInformation { id = 12, Name = "Просмотр страницы добавления группы" },
                new LoggingInformation { id = 13, Name = "Добавление группы" },
                new LoggingInformation { id = 14, Name = "Просмотр страницы добавления группы пользователю" },
                new LoggingInformation { id = 15, Name = "Добавление группы пользователю" },
                new LoggingInformation { id = 16, Name = "Просмотр страницы списка пользователей для отправки сообщения" },
                new LoggingInformation { id = 17, Name = "Просмотр страницы отправки сообщения" },
                new LoggingInformation { id = 18, Name = "Просмотр страницы полученных сообщений" },
                new LoggingInformation { id = 19, Name = "Открытие сообщения" }
            });

            modelBuilder.Entity<Pol>().HasData(new Pol[]
            {
                  new Pol { id = 1, Name = "Мужчина" },
                  new Pol { id = 2, Name = "Женщина" }
            });

            modelBuilder.Entity<Country>().HasData(new Country[]
            {
                new Country { id = 1, Name = "Россия" },
                new Country { id = 2, Name = "Англия" }
            });

            modelBuilder.Entity<Domain>().HasData(new Domain[]
            {
                new Domain { Id = "3bbdb487-599b-4457-ac65-fae30e8ff437", Name = "@bk.ru" },
                new Domain { Id = "2e208829-8a25-4265-81f2-79afaba9f16d", Name = "@bk.com" }
            });

            /*
             * delete from AddresseeMessages
               delete from Messages
               delete from ThemeMessages
               delete from LoggingInformation
               delete from Loggings
               delete from Participants
               delete from AspNetUsers
               delete from Teams
               delete from TeamUser
               delete from AspNetRoles

              */
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLoggerFactory(MyLoggerFactoryTrace);
        }

        public static readonly ILoggerFactory MyLoggerFactoryTrace = LoggerFactory.Create(builder =>
        {
            builder.AddFilter((category, level) => category == DbLoggerCategory.Database.Command.Name && level == LogLevel.Warning)
            .AddProvider(new MyLoggerProvider());
        });
    }
}
