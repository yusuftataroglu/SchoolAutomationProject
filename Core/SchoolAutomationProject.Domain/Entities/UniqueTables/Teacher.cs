using SchoolAutomationProject.Domain.Entities.CommonTables;
using SchoolAutomationProject.Domain.Entities.CrossTables;

namespace SchoolAutomationProject.Domain.Entities.UniqueTables
{
    public class Teacher : BaseClass
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Role { get; set; }
        public string Department { get; set; }

        //Teacher-MainCourse ilişkisi
        public virtual MainCourse MainCourse { get; set; }
        public Guid MainCourseId { get; set; }

        //Teacher-Classroom ilişkisi
        public virtual ICollection<ClassroomTeacher> ClassroomTeachers { get; set; }

        //Teacher-TeacherSchedule ilişkisi
        public virtual ICollection<TeacherSchedule> TeacherSchedules { get; set; }

        //Teacher-Student ilişkisi
        //KALDIRILDI
        //public virtual ICollection<StudentTeacher> StudentTeachers { get; set; }


    }
}
