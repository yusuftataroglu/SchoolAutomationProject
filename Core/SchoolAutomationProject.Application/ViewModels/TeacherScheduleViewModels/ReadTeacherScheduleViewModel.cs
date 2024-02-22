using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Application.ViewModels.TeacherScheduleViewModels
{
    public class ReadTeacherScheduleViewModel:ReadViewModel
    {
        public DateTime DateTime { get; set; }
        public DayOfWeek Day { get; set; }
        public byte TimeSlot { get; set; }
        public string? Classroom { get; set; }

        //TeacherSchedule - Teacher ilişkisi
        public virtual Teacher Teacher { get; set; }
    }
}
