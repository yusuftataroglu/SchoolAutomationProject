using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolAutomationProject.Domain.Entities.UniqueTables;
using System;

namespace SchoolAutomationProject.Persistence.Configurations.UniqueTableConfigurations
{
    public class SemesterConfiguration : IEntityTypeConfiguration<Semester>
    {
        public void Configure(EntityTypeBuilder<Semester> builder)
        {
            //BaseClass'tan gelen property özelleştirmeleri
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.CreatedComputerName).HasMaxLength(255).IsRequired();
            builder.Property(x => x.CreatedIpAddress).HasMaxLength(255).IsRequired();
            builder.Property(x => x.UpdatedComputerName).HasMaxLength(255);
            builder.Property(x => x.UpdatedIpAddress).HasMaxLength(255);

            //Bu tabloya ait propertylerin özelleştirmeleri
            builder.Property(x => x.Name).HasMaxLength(255).IsRequired();
            builder.Property(x => x.StartDate).IsRequired();
            builder.Property(x => x.EndDate).IsRequired();

            builder.HasData(GetSampleSemesters());
        }

        public List<Semester> GetSampleSemesters()
        {
            List<Semester> semesters = new List<Semester>
    {
        new Semester
        {
            Id = Guid.Parse("afdfe876-3b49-4d60-9e1b-ddf2961bce56"),
            Name = "2022-2023 Spring Season",
            StartDate = new DateTime(2022, 2, 1),
            EndDate = new DateTime(2022, 6, 30),
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer1",
            CreatedIpAddress = "192.168.1.1"
        },
        new Semester
        {
            Id = Guid.Parse("ac317057-dc54-44bc-a43c-e85c8f414044"),
            Name = "2022-2023 Fall Season",
            StartDate = new DateTime(2022, 9, 1),
            EndDate = new DateTime(2022, 12, 31),
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer2",
            CreatedIpAddress = "192.168.1.2"
        },
        new Semester
        {
            Id = Guid.Parse("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"),
            Name = "2023-2024 Spring Season",
            StartDate = new DateTime(2023, 2, 1),
            EndDate = new DateTime(2023, 6, 30),
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer3",
            CreatedIpAddress = "192.168.1.3"
        },
        new Semester
        {
            Id = Guid.Parse("8929bfa5-e201-447a-a013-808a1672bbd5"),
            Name = "2023-2024 Fall Season",
            StartDate = new DateTime(2023, 9, 1),
            EndDate = new DateTime(2023, 12, 31),
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer4",
            CreatedIpAddress = "192.168.1.4"
        },
        new Semester
        {
            Id = Guid.Parse("851ed332-2317-4dd5-9076-63a9a46172c6"),
            Name = "2024-2025 Spring Season",
            StartDate = new DateTime(2024, 2, 1),
            EndDate = new DateTime(2024, 6, 30),
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer5",
            CreatedIpAddress = "192.168.1.5"
        }
    };

            return semesters;
        }

    }
}
