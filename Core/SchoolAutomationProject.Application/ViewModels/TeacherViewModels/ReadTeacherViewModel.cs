using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using SchoolAutomationProject.Domain.Entities.CrossTables;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using SchoolAutomationProject.Domain.Entities.IdentityTables;

namespace SchoolAutomationProject.Application.ViewModels.TeacherViewModels
{
    public class ReadTeacherViewModel : ReadViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Title { get; set; }
        public MainCourse MainCourse { get; set; }
        public ICollection<ClassroomTeacher> ClassroomTeachers { get; set; }
        public ICollection<TeacherSchedule> TeacherSchedules { get; set; }
        public AppUser User { get; set; }

    }
}
