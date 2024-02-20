using SchoolAutomationProject.Domain.Entities.CommonTables;
using SchoolAutomationProject.Domain.Entities.CrossTables;

namespace SchoolAutomationProject.Domain.Entities.CustomTables
{
    public class Classroom : BaseClass
    {
        public Classroom()
        {
            //ClassroomMainCourses = new List<ClassroomMainCourse>();
            //Students = new List<Student>();
            //ClassroomTeachers = new List<ClassroomTeacher>();
        }
        public string Name { get; set; } // Sınıf
        public byte Capacity { get; set; } // Kapasite

        // Derslik - Ders ilişkisi
        public virtual ICollection<ClassroomMainCourse> ClassroomMainCourses{ get; set; }
        // Sınıf - Öğrenci ilişkisi
        public virtual ICollection<Student> Students { get; set; }

        //Classroom-Teacher ilişkisi
        public virtual ICollection<ClassroomTeacher> ClassroomTeachers { get; set; }
    }
}
