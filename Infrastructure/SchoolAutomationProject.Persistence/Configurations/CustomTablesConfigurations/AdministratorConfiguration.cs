using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Persistence.Configurations.CustomTablesConfigurations
{
    public class AdministratorConfiguration : IEntityTypeConfiguration<Administrator>
    {
        public void Configure(EntityTypeBuilder<Administrator> builder)
        {
            //BaseClass'tan gelen property özelleştirmeleri
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.CreatedComputerName).HasMaxLength(255).IsRequired();
            builder.Property(x => x.CreatedIpAddress).HasMaxLength(255).IsRequired();
            builder.Property(x => x.UpdatedComputerName).HasMaxLength(255);
            builder.Property(x => x.UpdatedIpAddress).HasMaxLength(255);

            //Bu tabloya ait propertylerin özelleştirmeleri
            builder.Property(a => a.FirstName)
               .HasMaxLength(50)
               .IsRequired(); // FirstName sütununu zorunlu yapar

            builder.Property(a => a.LastName)
                .HasMaxLength(50)
                .IsRequired(); // LastName sütununu zorunlu yapar

            // Title için nullable olduğunu belirtir
            builder.Property(a => a.Title)
                .HasMaxLength(50)
                .IsRequired(false);

            // UserId için navigation property konfigürasyonu
            builder.HasOne(a => a.User)
                .WithOne(u => u.Administrator)
                .HasForeignKey<Administrator>(a => a.UserId)
                .IsRequired(false); // UserId ilişkisini belirtir ve zorunlu olmadığını ifade eder
        }
    }
}
