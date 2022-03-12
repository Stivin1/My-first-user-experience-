using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OpenSourceEnity.Models.Entities.SystemEntities;
namespace OpenSourceEnity.Models.ApplicationContextdb.CountryAppConfiguration
{
    public class CountryAppConfigurationBuilder : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder
                .HasKey(t => t.id);
            builder
                .Property(t => t.Name)
                .HasColumnType("nvarchar")
                .HasMaxLength(50)
                .IsRequired();

        }
    }
}
