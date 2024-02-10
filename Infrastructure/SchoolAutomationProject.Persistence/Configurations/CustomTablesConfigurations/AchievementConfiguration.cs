using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolAutomationProject.Domain.Entities.Enums;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Persistence.Configurations.CustomTablesConfigurations
{
    public class AchievementConfiguration : IEntityTypeConfiguration<Achievement>
    {
        public void Configure(EntityTypeBuilder<Achievement> builder)
        {
            //BaseClass'tan gelen property özelleştirmeleri
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.CreatedComputerName).HasMaxLength(255).IsRequired();
            builder.Property(x => x.CreatedIpAddress).HasMaxLength(255).IsRequired();
            builder.Property(x => x.UpdatedComputerName).HasMaxLength(255);
            builder.Property(x => x.UpdatedIpAddress).HasMaxLength(255);

            //Bu tabloya ait propertylerin özelleştirmeleri
            builder.Property(x => x.Type).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(255);

            builder.HasData(GetSampleAchievements());
        }

        public List<Achievement> GetSampleAchievements()
        {
            Random rnd = new();
            var semesterConfiguration = new SemesterConfiguration();
            var semesterList = semesterConfiguration.GetSampleSemesters();
            var studentConfiguration = new StudentConfiguration();
            var studentList = studentConfiguration.GetSampleStudents();
            int i = 0;
            var achievementList = new List<Achievement>();
            foreach (var semester in semesterList)
            {
                foreach (var student in studentList)
                {
                    var achievement = new Achievement
                    {
                        Id = Guid.NewGuid(),
                        Type = (AchievementType)rnd.Next(0, 3),
                        StudentId = student.Id,
                        SemesterId = semester.Id,
                        CreatedDate = DateTime.UtcNow,
                        CreatedComputerName = $"Computer{i + 1}",
                        CreatedIpAddress = $"192.168.1.{rnd.Next(1, 100)}"
                    };
                    i++;
                    achievementList.Add(achievement);
                }
            }
            return achievementList;
        }
    }
}
