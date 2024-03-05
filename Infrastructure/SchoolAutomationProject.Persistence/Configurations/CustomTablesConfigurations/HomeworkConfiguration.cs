using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Persistence.Configurations.CustomTablesConfigurations
{
    public class HomeworkConfiguration : IEntityTypeConfiguration<Homework>
    {
        public void Configure(EntityTypeBuilder<Homework> builder)
        {
            //BaseClass'tan gelen property özelleştirmeleri
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.CreatedComputerName).HasMaxLength(255).IsRequired();
            builder.Property(x => x.CreatedIpAddress).HasMaxLength(255).IsRequired();
            builder.Property(x => x.UpdatedComputerName).HasMaxLength(255);
            builder.Property(x => x.UpdatedIpAddress).HasMaxLength(255);

            //Bu tabloya ait propertylerin özelleştirmeleri
            builder.Property(h => h.Title)
                .HasMaxLength(50)
                .IsRequired(); // Title sütununu zorunlu yapar

            // Description için nullable olduğunu belirtir
            builder.Property(h => h.Description)
                .HasMaxLength(1000)
                .IsRequired(false);

            builder.Property(h => h.FileUrl)
                .HasMaxLength(255)
                .IsRequired(); // FileUrl sütununu zorunlu yapar

            // StudentId için navigation property konfigürasyonu
            builder.HasOne(h => h.Student)
                .WithMany(s => s.Homeworks)
                .HasForeignKey(h => h.StudentId)
                .IsRequired(); // StudentId ilişkisini belirtir ve silme işlemi kaskad olarak ayarlanır

            // SubCourseId için navigation property konfigürasyonu
            builder.HasOne(h => h.SubCourse)
                .WithMany(sc => sc.Homeworks)
                .HasForeignKey(h => h.SubCourseId)
                .IsRequired(); // SubCourseId ilişkisini belirtir ve silme işlemi kısıtlanır
        }
    }
}
