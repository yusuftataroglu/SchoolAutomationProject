using SchoolAutomationProject.Domain.Entities.CommonTables;
using SchoolAutomationProject.Domain.Entities.Enums;

namespace SchoolAutomationProject.Domain.Entities.UniqueTables
{
    public class Classroom : BaseClass
    {
        public string Grade { get; set; } // Sınıf (1, 2, ...)
        public Section Section { get; set; } // Şube (A, B, C, ...)

        // Derslik - Ders ilişkisi
        public virtual ICollection<MainCourse> MainCourses { get; set; }
        // Sınıf - Öğrenci ilişkisi
        public virtual ICollection<Student> Students { get; set; }

        //Classroom-Teacher ilişkisi
        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}
