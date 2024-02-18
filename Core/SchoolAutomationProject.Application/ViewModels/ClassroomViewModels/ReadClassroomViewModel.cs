using SchoolAutomationProject.Domain.Entities.CommonTables;
using SchoolAutomationProject.Domain.Entities.CrossTables;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Application.ViewModels.ClassroomViewModels
{
    public class ReadClassroomViewModel : BaseClass
    {
        public string Name { get; set; } // Sınıf
        public byte Capacity { get; set; } // Kapasite
        // Derslik - Ders ilişkisi
        public ICollection<ClassroomMainCourse> ClassroomMainCourses { get; set; }
        // Sınıf - Öğrenci ilişkisi
        public ICollection<Student> Students { get; set; }

        //Classroom-Teacher ilişkisi
        public ICollection<ClassroomTeacher> ClassroomTeachers { get; set; }
    }
}
