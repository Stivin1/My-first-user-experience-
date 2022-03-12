using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OpenSourceEnity.Models.Entities.SystemEntities;

namespace OpenSourceEnity.Models.ApplicationContextdb.ParticipantAppConfiguration
{
    public class ParticipantAppConfigurationBuilder : IEntityTypeConfiguration<Participant>
    {
        public void Configure(EntityTypeBuilder<Participant> builder)
        {
            builder
                .HasKey(t => t.id);
            builder
                .Property(t => t.Name)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(20);
            builder
                .Property(t => t.MiddleName)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(20);
            builder
                .Property(t => t.LastName)
                .HasColumnType("nvarchar")
                .IsRequired()
                .HasMaxLength(20);
            builder
                .Property(t => t.DateAge)
                .IsRequired()
                .HasColumnType("nvarchar(max)");

            builder
                .HasOne(t => t.Pol)
                .WithMany(t => t.Participant)
                .HasForeignKey(t => t.PolId);
            builder
                .HasOne(t => t.Country)
                .WithMany(t => t.Participant)
                .HasForeignKey(t => t.CountryId);

        }
    }
}
