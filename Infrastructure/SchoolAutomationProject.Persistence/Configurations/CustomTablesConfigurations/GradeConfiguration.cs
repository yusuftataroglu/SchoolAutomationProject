using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Persistence.Configurations.CustomTablesConfigurations
{
    public class GradeConfiguration : IEntityTypeConfiguration<Grade>
    {
        public void Configure(EntityTypeBuilder<Grade> builder)
        {
            //BaseClass'tan gelen property özelleştirmeleri
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.CreatedComputerName).HasMaxLength(255).IsRequired();
            builder.Property(x => x.CreatedIpAddress).HasMaxLength(255).IsRequired();
            builder.Property(x => x.UpdatedComputerName).HasMaxLength(255);
            builder.Property(x => x.UpdatedIpAddress).HasMaxLength(255);

            //Bu tabloya ait propertylerin özelleştirmeleri
            builder.Property(x => x.Score).IsRequired();
            builder.Property(x => x.ExamNumber).IsRequired();

            //builder.HasData(GetSampleGrades());
        }

        public List<Grade> GetSampleGrades()
        {
            Random rnd = new Random();
            var studentConfiguration = new StudentConfiguration();
            var studentList = studentConfiguration.GetSampleStudents();
            var subCourseConfiguration = new SubCourseConfiguration();
            var subCourseList = subCourseConfiguration.GetSampleSubCourses();
            List<Grade> grades = new();

            for (int i = 0; i < 1; i++)
            {
                foreach (var student in studentList)
                {
                    foreach (var subCourse in subCourseList)
                    {
                       var grade = new Grade
                        {
                            Id = Guid.NewGuid(),
                            Score = Math.Floor(rnd.NextDouble() * 100),
                            ExamNumber = Convert.ToByte(i + 1),
                            StudentId = student.Id,
                            SubCourseId = subCourse.Id,
                            CreatedDate = DateTime.UtcNow,
                            CreatedComputerName= $"Computer{i}",
                            CreatedIpAddress = $"192.168.1.{rnd.Next(1,100)}"
                        };
                        grades.Add(grade);
                    }
                }
            }
            return grades;
        }

    }
}
