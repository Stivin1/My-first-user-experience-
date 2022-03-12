using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OpenSourceEnity.Models.Entities.SystemEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenSourceEnity.Models.ApplicationContextdb.TeamAppConfiguration
{
    public class TeamAppConfigurationBuilder : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.HasMany(t => t.Users)
                    .WithMany(t => t.Teams);

            builder.Property(t => t.Name)
                .HasColumnType("nvarchar")
                .IsRequired()
                .HasMaxLength(20);
        }
    }
}
