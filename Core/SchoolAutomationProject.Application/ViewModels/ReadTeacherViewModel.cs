using SchoolAutomationProject.Domain.Entities.CommonTables;
using SchoolAutomationProject.Domain.Entities.CrossTables;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using SchoolAutomationProject.Domain.Entities.Enums;

namespace SchoolAutomationProject.Application.ViewModels
{
    public class ReadTeacherViewModel:BaseClass
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Role { get; set; }
        public string Department { get; set; }

        public ICollection<ClassroomTeacher> ClassroomTeachers { get; set; }
        public ICollection<TeacherSchedule> TeacherSchedules { get; set; }
    }
}
