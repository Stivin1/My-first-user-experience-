using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OpenSourceEnity.Models.Entities.SystemEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenSourceEnity.Models.ApplicationContextdb.PolAppConfiguration
{
    public class PolAppConfigurationBuilder : IEntityTypeConfiguration<Pol>
    {
        public void Configure(EntityTypeBuilder<Pol> builder)
        {
            builder
                .HasKey(t => t.id);

            builder
                .Property(t => t.Name)
                .HasColumnType("nvarchar")
                .HasMaxLength(20);
        }
    }
}
