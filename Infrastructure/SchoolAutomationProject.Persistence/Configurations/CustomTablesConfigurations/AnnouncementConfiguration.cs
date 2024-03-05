using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Persistence.Configurations.CustomTablesConfigurations
{
    public class AnnouncementConfiguration : IEntityTypeConfiguration<Announcement>
    {
        public void Configure(EntityTypeBuilder<Announcement> builder)
        {
            //BaseClass'tan gelen property özelleştirmeleri
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.CreatedComputerName).HasMaxLength(255).IsRequired();
            builder.Property(x => x.CreatedIpAddress).HasMaxLength(255).IsRequired();
            builder.Property(x => x.UpdatedComputerName).HasMaxLength(255);
            builder.Property(x => x.UpdatedIpAddress).HasMaxLength(255);

            //Bu tabloya ait propertylerin özelleştirmeleri  
            builder.Property(a => a.Title)
              .HasMaxLength(255)
              .IsRequired(); // Title sütununu zorunlu yapar

            builder.Property(a => a.Content)
                .HasMaxLength(5000)
                .IsRequired(); // Content sütununu zorunlu yapar

            builder.Property(a => a.CreatorId)
                .IsRequired(); // CreatorId sütununu zorunlu yapar

            // Admin için navigation property konfigürasyonu
            builder.HasOne(a => a.Admin)
                .WithMany(a=> a.Announcements)
                .HasForeignKey(a => a.CreatorId)
                .IsRequired(false); // Admin ilişkisini belirtir ve zorunlu olmadığını ifade eder

            // Teacher için navigation property konfigürasyonu
            builder.HasOne(a => a.Teacher)
                .WithMany(a=> a.Announcements)
                .HasForeignKey(a => a.CreatorId)
                .IsRequired(false); // Teacher ilişkisini belirtir ve zorunlu olmadığını ifade eder
        }
    }
}
