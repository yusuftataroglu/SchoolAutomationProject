using SchoolAutomationProject.Domain.Entities.CommonTables;
using SchoolAutomationProject.Domain.Entities.Enums;

namespace SchoolAutomationProject.Domain.Entities.UniqueTables
{
    public class Attendance : BaseClass
    {
        public DateTime AttendanceDate { get; set; } // Devamsızlık tarihi
        public AttendanceStatus AttendanceStatus { get; set; }

        // Devamsızlık - Öğrenci ilişkisi
        public virtual Student Student { get; set; }
        public Guid StudentId { get; set; } // Öğrenci ID'si

        // Devamsızlık - Ders ilişkisi
        public virtual SubCourse SubCourse { get; set; }
        public Guid SubCourseId { get; set; } // Ders ID'si
    }
}
