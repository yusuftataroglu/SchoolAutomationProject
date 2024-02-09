using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolAutomationProject.Domain.Entities.CrossTables;
using SchoolAutomationProject.Domain.Entities.UniqueTables;
using SchoolAutomationProject.Persistence.Contexts;

namespace SchoolAutomationProject.Persistence.Configurations.CrossTableConfigurations
{
    public class ClassroomTeacherConfiguration : IEntityTypeConfiguration<ClassroomTeacher>
    {
        //SchoolAutomationProjectDbContext _context = new SchoolAutomationProjectDbContext();

        public void Configure(EntityTypeBuilder<ClassroomTeacher> builder)
        {
            builder.HasKey(x => new { x.ClassroomId, x.TeacherId });
            builder.HasOne(x => x.Classroom).WithMany(x => x.ClassroomTeachers).HasForeignKey(x => x.ClassroomId).IsRequired();
            builder.HasOne(x => x.Teacher).WithMany(x => x.ClassroomTeachers).HasForeignKey(x => x.TeacherId).IsRequired();

            //builder.HasData(GetSampleClassroomTeachers());
        }

        //private List<ClassroomTeacher> GetSampleClassroomTeachers()
        //{
        //    List<ClassroomTeacher> classroomTeachers = new List<ClassroomTeacher>();
        //    var teacherIds = _context.Teachers.Select(x=> x.Id).ToList();
        //    var classroomIds = _context.Classrooms.Select(x=> x.Id).ToList();

        //    foreach (var teacherId in teacherIds)
        //    {
        //        foreach (var classroomId in classroomIds)
        //        {
        //            classroomTeachers.Add(new ClassroomTeacher
        //            {
        //                TeacherId = teacherId,
        //                ClassroomId = classroomId
        //            });
        //        }
        //    }

        //    return classroomTeachers;
        //}
    }
}
