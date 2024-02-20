using SchoolAutomationProject.Domain.Entities.CommonTables;
using SchoolAutomationProject.Domain.Entities.CrossTables;
using SchoolAutomationProject.Domain.Entities.IdentityTables;

namespace SchoolAutomationProject.Domain.Entities.CustomTables
{
    public class Teacher : BaseClass
    {
        public Teacher()
        {
            //ClassroomTeachers = new List<ClassroomTeacher>();
            //TeacherSchedules = new List<TeacherSchedule>();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Title { get; set; }

        //Teacher-MainCourse ilişkisi
        public virtual MainCourse MainCourse { get; set; }
        public Guid? MainCourseId { get; set; }

        //Teacher-Classroom ilişkisi
        public virtual ICollection<ClassroomTeacher> ClassroomTeachers { get; set; }

        //Teacher-TeacherSchedule ilişkisi
        public virtual ICollection<TeacherSchedule> TeacherSchedules { get; set; }

        //Teacher-AppUser ilişkisi
        public virtual AppUser User { get; set; }
        public string? UserId { get; set; }

        //Teacher-Student ilişkisi
        //KALDIRILDI
        //public virtual ICollection<StudentTeacher> StudentTeachers { get; set; }


    }
}
