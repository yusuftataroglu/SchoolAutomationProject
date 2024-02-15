using SchoolAutomationProject.Domain.Entities.CommonTables;
using SchoolAutomationProject.Domain.Entities.Enums;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Domain.Entities.CustomTables
{
    public class TeacherSchedule : BaseClass
    {
        public DateTime DateTime { get; set; }
        public DayOfWeek Day { get; set; }
        public byte TimeSlot { get; set; }
        public string? Classroom { get; set; }

        //TeacherSchedule - Teacher ilişkisi
        public virtual Teacher Teacher { get; set; }
        public Guid TeacherId { get; set; }
    }
}
