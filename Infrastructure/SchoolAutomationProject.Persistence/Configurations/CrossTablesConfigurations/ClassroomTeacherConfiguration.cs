using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolAutomationProject.Domain.Entities.CrossTables;
using SchoolAutomationProject.Persistence.Configurations.CustomTablesConfigurations;

namespace SchoolAutomationProject.Persistence.Configurations.CrossTablesConfigurations
{
    public class ClassroomTeacherConfiguration : IEntityTypeConfiguration<ClassroomTeacher>
    {

        public void Configure(EntityTypeBuilder<ClassroomTeacher> builder)
        {
            builder.HasKey(x => new { x.ClassroomId, x.TeacherId });
            builder.HasOne(x => x.Classroom).WithMany(x => x.ClassroomTeachers).HasForeignKey(x => x.ClassroomId).IsRequired();
            builder.HasOne(x => x.Teacher).WithMany(x => x.ClassroomTeachers).HasForeignKey(x => x.TeacherId).IsRequired();

            //builder.HasData(GetSampleClassroomTeachers());
        }

        private List<ClassroomTeacher> GetSampleClassroomTeachers()
        {
            var classroomConfiguration = new ClassroomConfiguration();
            var classroomList = classroomConfiguration.GetSampleClassrooms();
            var teacherConfiguration = new TeacherConfiguration();
            var teacherList = teacherConfiguration.GetSampleTeachers();
            List<ClassroomTeacher> classroomTeachers = new List<ClassroomTeacher>();

            foreach (var classroom in classroomList)
            {
                foreach (var teacher in teacherList)
                {
                    classroomTeachers.Add(new ClassroomTeacher { ClassroomId = classroom.Id, TeacherId = teacher.Id });
                }
            }
            return classroomTeachers;



        }
    }
}
