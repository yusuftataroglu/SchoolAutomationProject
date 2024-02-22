using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using SchoolAutomationProject.Domain.Entities.Enums;

namespace SchoolAutomationProject.Application.ViewModels.AttendanceViewModels

{
    public class ReadAttendanceViewModel:ReadViewModel
    {
        public DateTime AttendanceDate { get; set; } // Devamsızlık tarihi
        public AttendanceStatus AttendanceStatus { get; set; }

        // Devamsızlık - Öğrenci ilişkisi
        public virtual Student Student { get; set; }

        // Devamsızlık - Ders ilişkisi
        public virtual SubCourse SubCourse { get; set; }
    }
}
