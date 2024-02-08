using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolAutomationProject.Domain.Entities.Enums;
using SchoolAutomationProject.Domain.Entities.UniqueTables;

namespace SchoolAutomationProject.Persistence.Configurations.UniqueTableConfigurations
{
    public class ClassroomConfiguration : IEntityTypeConfiguration<Classroom>
    {
        public void Configure(EntityTypeBuilder<Classroom> builder)
        {
            //BaseClass'tan gelen property özelleştirmeleri
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.CreatedComputerName).HasMaxLength(255).IsRequired();
            builder.Property(x => x.CreatedIpAddress).HasMaxLength(255).IsRequired();
            builder.Property(x => x.UpdatedComputerName).HasMaxLength(255);
            builder.Property(x => x.UpdatedIpAddress).HasMaxLength(255);

            //Bu tabloya ait propertylerin özelleştirmeleri
            builder.Property(x => x.Grade).HasMaxLength(2).IsRequired();
            builder.Property(x => x.Section).IsRequired();
            builder.Property(x => x.Capacity).IsRequired();

            builder.HasData(GetSampleClassrooms());
        }

        public List<Classroom> GetSampleClassrooms()
        {
            List<Classroom> classrooms = new List<Classroom>
    {
        new Classroom
        {
            Id = Guid.Parse("666917cb-ccff-46e2-81be-1dc06b74ddcb"),
            Grade = "1",
            Section = Section.A,
            Capacity = 25,
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer1",
            CreatedIpAddress = "192.168.1.1"
        },
        new Classroom
        {
            Id = Guid.Parse("22d118a6-a81b-435f-a4c7-ffed69e37f12"),
            Grade = "1",
            Section = Section.B,
            Capacity = 25,
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer2",
            CreatedIpAddress = "192.168.1.2"
        },
        new Classroom
        {
            Id = Guid.Parse("05c0da3b-87a7-4b85-b3e6-aa133dbab5f0"),
            Grade = "2",
            Section = Section.A,
            Capacity = 25,
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer3",
            CreatedIpAddress = "192.168.1.3"
        },
        new Classroom
        {
            Id = Guid.Parse("7a3741e2-d501-4710-b0c9-a0a53142ad79"),
            Grade = "2",
            Section = Section.B,
            Capacity = 25,
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer4",
            CreatedIpAddress = "192.168.1.4"
        },
    };

            return classrooms;
        }

    }
}
