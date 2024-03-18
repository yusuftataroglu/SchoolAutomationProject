using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Persistence.Configurations.CustomTablesConfigurations
{
    public class TeacherScheduleConfiguration : IEntityTypeConfiguration<TeacherSchedule>
    {
        public void Configure(EntityTypeBuilder<TeacherSchedule> builder)
        {
            //BaseClass'tan gelen property özelleştirmeleri
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.CreatedComputerName).HasMaxLength(255).IsRequired();
            builder.Property(x => x.CreatedIpAddress).HasMaxLength(255).IsRequired();
            builder.Property(x => x.UpdatedComputerName).HasMaxLength(255);
            builder.Property(x => x.UpdatedIpAddress).HasMaxLength(255);

            //Bu tabloya ait propertylerin özelleştirmeleri
            builder.Property(x => x.Day);
            builder.Property(x => x.Classroom).HasMaxLength(9).IsRequired();

            //builder.HasData(GetSampleTeacherSchedule());

        }

        public List<TeacherSchedule> GetSampleTeacherSchedule()
        {
            List<TeacherSchedule> teacherSchedules = new()
            {
                new TeacherSchedule
                {
                    Id=Guid.NewGuid(),
                    DateTime=DateTime.UtcNow.Date,
                    Day=DayOfWeek.Sunday,
                    TimeSlot=1,
                    CreatedDate = DateTime.UtcNow,
                    CreatedComputerName = "Computer1",
                    CreatedIpAddress = "192.168.1.1",
                    Classroom= "1-A",
                    TeacherId=Guid.Parse("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76")
                },
                new TeacherSchedule
                {
                    Id=Guid.NewGuid(),
                    DateTime=DateTime.UtcNow.Date,
                    Day=DayOfWeek.Sunday,
                    TimeSlot=2,
                    CreatedDate = DateTime.UtcNow,
                    CreatedComputerName = "Computer1",
                    CreatedIpAddress = "192.168.1.1",
                    Classroom= "1-A",
                    TeacherId=Guid.Parse("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76")
                },
                new TeacherSchedule
                {
                    Id=Guid.NewGuid(),
                    DateTime=DateTime.UtcNow.Date,
                    Day=DayOfWeek.Sunday,
                    TimeSlot=3,
                    CreatedDate = DateTime.UtcNow,
                    CreatedComputerName = "Computer1",
                    CreatedIpAddress = "192.168.1.1",
                    Classroom= "2-B",
                    TeacherId=Guid.Parse("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76")
                },
                new TeacherSchedule
                {
                    Id=Guid.NewGuid(),
                    DateTime=DateTime.UtcNow.Date,
                    Day=DayOfWeek.Sunday,
                    TimeSlot=4,
                    CreatedDate = DateTime.UtcNow,
                    CreatedComputerName = "Computer1",
                    CreatedIpAddress = "192.168.1.1",
                    Classroom= "2-B",
                    TeacherId=Guid.Parse("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76")
                },
                new TeacherSchedule
                {
                    Id=Guid.NewGuid(),
                    DateTime=DateTime.UtcNow.Date,
                    Day=DayOfWeek.Sunday,
                    TimeSlot=5,
                    CreatedDate = DateTime.UtcNow,
                    CreatedComputerName = "Computer1",
                    CreatedIpAddress = "192.168.1.1",
                    Classroom= "3-D",
                    TeacherId=Guid.Parse("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76")
                },
                new TeacherSchedule
                {
                    Id=Guid.NewGuid(),
                    DateTime=DateTime.UtcNow.Date,
                    Day=DayOfWeek.Sunday,
                    TimeSlot=6,
                    CreatedDate = DateTime.UtcNow,
                    CreatedComputerName = "Computer1",
                    CreatedIpAddress = "192.168.1.1",
                    Classroom= "3-D",
                    TeacherId=Guid.Parse("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76")
                },
                new TeacherSchedule
                {
                    Id=Guid.NewGuid(),
                    DateTime=DateTime.UtcNow.Date,
                    Day=DayOfWeek.Sunday,
                    TimeSlot=7,
                    CreatedDate = DateTime.UtcNow,
                    CreatedComputerName = "Computer1",
                    CreatedIpAddress = "192.168.1.1",
                    Classroom= "",
                    TeacherId=Guid.Parse("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76")
                },
                new TeacherSchedule
                {
                    Id=Guid.NewGuid(),
                    DateTime=DateTime.UtcNow.Date,
                    Day=DayOfWeek.Sunday,
                    TimeSlot=8,
                    CreatedDate = DateTime.UtcNow,
                    CreatedComputerName = "Computer1",
                    CreatedIpAddress = "192.168.1.1",
                    Classroom= "",
                    TeacherId=Guid.Parse("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76")
                },
                new TeacherSchedule
                {
                    Id=Guid.NewGuid(),
                    DateTime=new DateTime(2023,2,14),
                    Day=DayOfWeek.Sunday,
                    TimeSlot=1,
                    CreatedDate = DateTime.UtcNow,
                    CreatedComputerName = "Computer1",
                    CreatedIpAddress = "192.168.1.1",
                    Classroom= "1-A",
                    TeacherId=Guid.Parse("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76")
                },
                new TeacherSchedule
                {
                    Id=Guid.NewGuid(),
                    DateTime=new DateTime(2023,2,14),
                    Day=DayOfWeek.Sunday,
                    TimeSlot=2,
                    CreatedDate = DateTime.UtcNow,
                    CreatedComputerName = "Computer1",
                    CreatedIpAddress = "192.168.1.1",
                    Classroom= "1-A",
                    TeacherId=Guid.Parse("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76")
                },
                new TeacherSchedule
                {
                    Id=Guid.NewGuid(),
                    DateTime=new DateTime(2023,2,14),
                    Day=DayOfWeek.Sunday,
                    TimeSlot=3,
                    CreatedDate = DateTime.UtcNow,
                    CreatedComputerName = "Computer1",
                    CreatedIpAddress = "192.168.1.1",
                    Classroom= "2-B",
                    TeacherId=Guid.Parse("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76")
                },
                new TeacherSchedule
                {
                    Id=Guid.NewGuid(),
                    DateTime=new DateTime(2023,2,14),
                    Day=DayOfWeek.Sunday,
                    TimeSlot=4,
                    CreatedDate = DateTime.UtcNow,
                    CreatedComputerName = "Computer1",
                    CreatedIpAddress = "192.168.1.1",
                    Classroom= "2-B",
                    TeacherId=Guid.Parse("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76")
                },
                new TeacherSchedule
                {
                    Id=Guid.NewGuid(),
                    DateTime=new DateTime(2023, 2, 14),
                    Day=DayOfWeek.Sunday,
                    TimeSlot=5,
                    CreatedDate = DateTime.UtcNow,
                    CreatedComputerName = "Computer1",
                    CreatedIpAddress = "192.168.1.1",
                    Classroom= "",
                    TeacherId=Guid.Parse("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76")
                },
                new TeacherSchedule
                {
                    Id=Guid.NewGuid(),
                    DateTime=new DateTime(2023,2,14),
                    Day=DayOfWeek.Sunday,
                    TimeSlot=6,
                    CreatedDate = DateTime.UtcNow,
                    CreatedComputerName = "Computer1",
                    CreatedIpAddress = "192.168.1.1",
                    Classroom= "",
                    TeacherId=Guid.Parse("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76")
                },
                new TeacherSchedule
                {
                    Id=Guid.NewGuid(),
                    DateTime=new DateTime(2023, 2, 14),
                    Day=DayOfWeek.Sunday,
                    TimeSlot=7,
                    CreatedDate = DateTime.UtcNow,
                    CreatedComputerName = "Computer1",
                    CreatedIpAddress = "192.168.1.1",
                    Classroom= "4-C",
                    TeacherId=Guid.Parse("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76")
                },
                new TeacherSchedule
                {
                    Id=Guid.NewGuid(),
                    DateTime=new DateTime(2023,2,14),
                    Day=DayOfWeek.Sunday,
                    TimeSlot=8,
                    CreatedDate = DateTime.UtcNow,
                    CreatedComputerName = "Computer1",
                    CreatedIpAddress = "192.168.1.1",
                    Classroom= "4-C",
                    TeacherId=Guid.Parse("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76")
                }
            };
            return teacherSchedules;
        }

    }
}
