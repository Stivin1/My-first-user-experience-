using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OpenSourceEnity.Models.Entities.SystemEntities;

namespace OpenSourceEnity.Models.ApplicationContextdb.AddresseeConfiguration
{
    public class AddresseeMessageAppConfigurationBuilder : IEntityTypeConfiguration<AddresseeMessage>
    {
        public void Configure(EntityTypeBuilder<AddresseeMessage> builder)
        {
            builder.HasKey(t => t.id);

            builder.HasOne(t => t.Message)
                .WithMany(t => t.addresseeMessages)
                .HasForeignKey(t => t.MessageId);

            builder.HasOne(t => t.User)
                .WithMany(t => t.AddresseeMessage)
                .HasForeignKey(t => t.UserId);
        }
    }
}
