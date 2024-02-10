using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Persistence.Configurations.CustomTablesConfigurations
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

            builder.HasData(GetSampleDiscontinuedStudents());
        }

        public List<DiscontinuedStudent> GetSampleDiscontinuedStudents()
        {
            Random rnd = new();
            int i = 0;
            List<DiscontinuedStudent> discontinuedStudents = new List<DiscontinuedStudent>
            {
                new DiscontinuedStudent
                {
                    Id=Guid.NewGuid(),
                    StudentId = Guid.Parse("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"),
                    CreatedDate = DateTime.UtcNow,
                            CreatedComputerName = $"Computer{i}",
                            CreatedIpAddress = $"192.168.1.{rnd.Next(1, 100)}"
                },
                new DiscontinuedStudent
                {
                    Id = Guid.NewGuid(),
                    StudentId = Guid.Parse("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"),
                    CreatedDate = DateTime.UtcNow,
                            CreatedComputerName = $"Computer{i+1}",
                            CreatedIpAddress = $"192.168.1.{rnd.Next(1, 100)}"
                }
            };
            return discontinuedStudents;
        }
    }
}
