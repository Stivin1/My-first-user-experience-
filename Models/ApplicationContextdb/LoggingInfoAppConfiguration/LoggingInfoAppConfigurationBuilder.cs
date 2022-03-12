using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OpenSourceEnity.Models.Entities.SystemEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenSourceEnity.Models.ApplicationContextdb.LoggingInfoAppConfiguration
{
    public class LoggingInfoAppConfigurationBuilder : IEntityTypeConfiguration<LoggingInformation>
    {
        public void Configure(EntityTypeBuilder<LoggingInformation> builder)
        {
            builder.HasKey(t => t.id);

            builder.Property(t => t.Name)
                .HasColumnType("nvarchar")
                .HasMaxLength(50);
        }
    }
}
