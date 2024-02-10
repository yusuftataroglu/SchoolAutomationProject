using SchoolAutomationProject.Domain.Entities.CommonTables;
using SchoolAutomationProject.Domain.Entities.Enums;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Domain.Entities.CustomTables
{
    public class TeacherSchedule:BaseClass
    {

        public Day Day { get; set; }
        public byte TimeSlot { get; set; }
        public string Classroom { get; set; } //todo değişebilir.

        //TeacherSchedule - Teacher ilişkisi
        public virtual Teacher Teacher { get; set; }
        public Guid TeacherId { get; set; }
    }
}
