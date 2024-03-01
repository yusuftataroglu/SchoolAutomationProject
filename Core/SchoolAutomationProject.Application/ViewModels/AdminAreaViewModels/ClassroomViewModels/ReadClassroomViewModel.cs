using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using SchoolAutomationProject.Domain.Entities.CommonTables;
using SchoolAutomationProject.Domain.Entities.CrossTables;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.ClassroomViewModels
{
    public class ReadClassroomViewModel : BaseClass, IReadViewModel
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
