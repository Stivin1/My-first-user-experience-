using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OpenSourceEnity.Models.Entities.SystemEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenSourceEnity.Models.ApplicationContextdb.ParticipantAudAppConfiguration
{
    public class ParticipantAudAppConfigurationBuilder : IEntityTypeConfiguration<Participant_AUD>
    {
        public void Configure(EntityTypeBuilder<Participant_AUD> builder)
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
                .HasOne(t => t.Participant)
                .WithMany(t => t.Participant_AUD)
                .HasForeignKey(t => t.ParticipantId);
        }
    }
}
