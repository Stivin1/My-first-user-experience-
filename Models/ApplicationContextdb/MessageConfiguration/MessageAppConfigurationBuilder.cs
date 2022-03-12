using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OpenSourceEnity.Models.Entities.SystemEntities;

namespace OpenSourceEnity.Models.ApplicationContextdb.MessageConfiguration
{
    public class MessageAppConfigurationBuilder : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            builder.HasKey(t => t.id);

            builder.Property(t => t.Text)
                .HasColumnType("nvarchar")
                .HasMaxLength(2000);

            builder.Property(t => t.DataCreate)
                .HasColumnType("nvarchar")
                .HasMaxLength(50);

            builder.HasOne(t => t.ThemeMessage)
                .WithOne(t => t.Message)
                .HasForeignKey<Message>(t => t.ThemeMessageId)
                .IsRequired();
        }
    }
}
