using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using SchoolAutomationProject.Domain.Entities.CrossTables;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Application.ViewModels.TeacherAreaViewModels.ClassroomViewModels
{
    public class ReadClassroomViewModel : IReadViewModel
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
