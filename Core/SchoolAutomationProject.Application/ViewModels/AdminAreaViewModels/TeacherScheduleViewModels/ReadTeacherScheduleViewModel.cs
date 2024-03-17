using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using SchoolAutomationProject.Domain.Entities.CommonTables;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.TeacherScheduleViewModels
{
    public class ReadTeacherScheduleViewModel : BaseClass, IReadViewModel
    {
        public DateTime DateTime { get; set; }
        public DayOfWeek Day { get; set; }
        public byte TimeSlot { get; set; }
        public string? Classroom { get; set; }

        //TeacherSchedule - Teacher ilişkisi
        public Teacher Teacher { get; set; }
        public string TeacherFullName => $"{Teacher.FirstName} {Teacher.LastName}";
        public string DateTimeShort => DateTime.ToShortDateString();

    }
}
