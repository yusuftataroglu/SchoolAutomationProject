using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolAutomationProject.Domain.Entities.CrossTables;
using SchoolAutomationProject.Persistence.Configurations.CustomTablesConfigurations;

namespace SchoolAutomationProject.Persistence.Configurations.CrossTablesConfigurations
{
    public class ClassroomMainCourseConfiguration : IEntityTypeConfiguration<ClassroomMainCourse>
    {
        public void Configure(EntityTypeBuilder<ClassroomMainCourse> builder)
        {
            builder.HasKey(x => new { x.ClassroomId, x.MainCourseId });
            builder.HasOne(x => x.Classroom).WithMany(x => x.ClassroomMainCourses).HasForeignKey(x => x.ClassroomId).IsRequired();
            builder.HasOne(x => x.MainCourse).WithMany(x => x.ClassroomMainCourses).HasForeignKey(x => x.MainCourseId).IsRequired();

            builder.HasData(GetSampleClassroomMainCourses());
        }

        public List<ClassroomMainCourse> GetSampleClassroomMainCourses()
        {
            var classroomConfiguration = new ClassroomConfiguration();
            var classroomList = classroomConfiguration.GetSampleClassrooms();
            var mainCourseConfiguration = new MainCourseConfiguration();
            var mainCourseList = mainCourseConfiguration.GetSampleMainCourses();
            List<ClassroomMainCourse> classroomMainCourses = new List<ClassroomMainCourse>();

            foreach (var classroom in classroomList)
            {
                foreach (var mainCourse in mainCourseList)
                {
                    classroomMainCourses.Add(new ClassroomMainCourse
                    {
                        ClassroomId = classroom.Id,
                        MainCourseId = mainCourse.Id
                    });
                }
            }

            return classroomMainCourses;
        }

    }
}
