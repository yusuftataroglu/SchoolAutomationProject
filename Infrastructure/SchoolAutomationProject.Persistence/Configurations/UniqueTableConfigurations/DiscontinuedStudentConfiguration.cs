using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolAutomationProject.Domain.Entities.UniqueTables;

namespace SchoolAutomationProject.Persistence.Configurations.UniqueTableConfigurations
{
    public class DiscontinuedStudentConfiguration : IEntityTypeConfiguration<DiscontinuedStudent>
    {
        public void Configure(EntityTypeBuilder<DiscontinuedStudent> builder)
        {
            //BaseClass'tan gelen property özelleştirmeleri
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.CreatedComputerName).HasMaxLength(255).IsRequired();
            builder.Property(x => x.CreatedIpAddress).HasMaxLength(255).IsRequired();
            builder.Property(x => x.UpdatedComputerName).HasMaxLength(255);
            builder.Property(x => x.UpdatedIpAddress).HasMaxLength(255);

            //Bu tabloya ait propertylerin özelleştirmeleri
            builder.Property(x => x.StudentId).IsRequired();
        }
    }
}
