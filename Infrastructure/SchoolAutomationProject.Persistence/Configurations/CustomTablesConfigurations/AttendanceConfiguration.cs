using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolAutomationProject.Domain.Entities.Enums;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Persistence.Configurations.CustomTablesConfigurations
{
    public class AttendanceConfiguration : IEntityTypeConfiguration<Attendance>
    {
        public void Configure(EntityTypeBuilder<Attendance> builder)
        {
            //BaseClass'tan gelen property özelleştirmeleri
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.CreatedComputerName).HasMaxLength(255).IsRequired();
            builder.Property(x => x.CreatedIpAddress).HasMaxLength(255).IsRequired();
            builder.Property(x => x.UpdatedComputerName).HasMaxLength(255);
            builder.Property(x => x.UpdatedIpAddress).HasMaxLength(255);

            //Bu tabloya ait propertylerin özelleştirmeleri
            builder.Property(x => x.AttendanceDate).IsRequired();
            builder.Property(x => x.AttendanceStatus).IsRequired();

            builder.HasData(GetSampleAttendaces());
        }

        public List<Attendance> GetSampleAttendaces()
        {
            SubCourseConfiguration subCourseConfiguration = new SubCourseConfiguration();
            var subCourseList = subCourseConfiguration.GetSampleSubCourses();
            StudentConfiguration studentConfiguration = new StudentConfiguration();
            var studentList = studentConfiguration.GetSampleStudents();
            Random rnd = new Random();
            int i = 0;
            List<Attendance> attendanceList = new();
            foreach (var student in studentList)
            {
                foreach (var subCourse in subCourseList)
                {
                    var zar = rnd.Next(1, 7);
                    if (zar == 1)
                    {
                        var attendance = new Attendance
                        {
                            Id = Guid.NewGuid(),
                            AttendanceDate = new DateTime(2023, rnd.Next(1, 13), rnd.Next(1, 28)),
                            AttendanceStatus = (AttendanceStatus)rnd.Next(0, 4),
                            StudentId = student.Id,
                            SubCourseId = subCourse.Id,
                            CreatedDate = DateTime.UtcNow,
                            CreatedComputerName = $"Computer{i}",
                            CreatedIpAddress = $"192.168.1.{rnd.Next(1, 100)}"
                        };
                        attendanceList.Add(attendance);
                        i++;
                    }

                }
            }
            return attendanceList;
        }
    }
}
