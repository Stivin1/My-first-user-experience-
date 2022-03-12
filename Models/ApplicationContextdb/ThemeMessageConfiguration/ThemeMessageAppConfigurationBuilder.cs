using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OpenSourceEnity.Models.Entities.SystemEntities;
using System;

namespace OpenSourceEnity.Models.ApplicationContextdb.ThemeMessageConfiguration
{
    public class ThemeMessageAppConfigurationBuilder : IEntityTypeConfiguration<ThemeMessage>
    {
        public void Configure(EntityTypeBuilder<ThemeMessage> builder)
        {
            builder.HasKey(t => t.id);

            builder.Property(t => t.Theme)
                .HasColumnType("nvarchar")
                .HasMaxLength(50);
        }
    }
}
