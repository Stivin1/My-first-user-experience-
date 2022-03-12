using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OpenSourceEnity.Models.Entities.SystemEntities;

namespace OpenSourceEnity.Models.ApplicationContextdb.UserAppConfiguration
{
    public class UserAppConfigurationBuilder : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
               .HasKey(t => t.Id);

            builder
                .Property(t => t.Age)
                .HasColumnType("int")
                .IsRequired()
                .HasMaxLength(100);
            builder
                .Property(t => t.DateCreate)
                .HasColumnType("nvarchar")
                .HasMaxLength(100)
                .IsRequired();

            builder
                .Property(t => t.DateChanges)
                .HasColumnType("nvarchar")
                .HasMaxLength(100)
                .IsRequired();

            builder
                .Property(t => t.DomainId)
                .IsRequired(false);

            builder
                .HasOne(t => t.Participant)
                .WithOne(t => t.User)
                .HasForeignKey<Participant>(t => t.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasOne(t => t.Domain)
                .WithMany(t => t.Users)
                .HasForeignKey(t => t.DomainId)
                .OnDelete(DeleteBehavior.Cascade);
                
        }
    }
}
