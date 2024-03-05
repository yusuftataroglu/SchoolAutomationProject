using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Persistence.Configurations.CustomTablesConfigurations
{
    public class MessageConfiguration : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            //BaseClass'tan gelen property özelleştirmeleri
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.CreatedComputerName).HasMaxLength(255).IsRequired();
            builder.Property(x => x.CreatedIpAddress).HasMaxLength(255).IsRequired();
            builder.Property(x => x.UpdatedComputerName).HasMaxLength(255);
            builder.Property(x => x.UpdatedIpAddress).HasMaxLength(255);

            //Bu tabloya ait propertylerin özelleştirmeleri
            builder.Property(m => m.Content)
                .HasMaxLength(2000)
                .IsRequired(); // Content sütununu zorunlu yapar

            // SenderId için foreign key ilişkisini belirtir
            builder.HasOne(x => x.Sender).WithMany(x => x.SentMessages).HasForeignKey(x => x.SenderId).IsRequired(false);


            // ReceiverId için foreign key ilişkisini belirtir
            builder.HasOne(x => x.Receiver).WithMany(x => x.ReceivedMessages).HasForeignKey(x => x.ReceiverId).IsRequired(false);
        }
    }
}