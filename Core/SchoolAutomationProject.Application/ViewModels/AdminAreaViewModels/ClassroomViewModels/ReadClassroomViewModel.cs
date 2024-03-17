using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using SchoolAutomationProject.Domain.Entities.CommonTables;
using SchoolAutomationProject.Domain.Entities.CrossTables;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.ClassroomViewModels
{
    public class ReadClassroomViewModel : BaseClass, IReadViewModel
    {
        public string Name { get; set; }
        public byte Capacity { get; set; }
        public ICollection<ClassroomMainCourse> ClassroomMainCourses { get; set; }
        public ICollection<Student> Students { get; set; }
        public ICollection<ClassroomTeacher> ClassroomTeachers { get; set; }
    }
}
