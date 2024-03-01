using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using SchoolAutomationProject.Domain.Entities.Enums;

namespace SchoolAutomationProject.Application.ViewModels.TeacherAreaViewModels.AttendanceViewModels

{
    public class ReadAttendanceViewModel : IReadViewModel
    {
        public DateTime AttendanceDate { get; set; } // Devamsızlık tarihi
        public AttendanceStatus AttendanceStatus { get; set; }

        // Devamsızlık - Öğrenci ilişkisi
        public Student Student { get; set; }

        // Devamsızlık - Ders ilişkisi
        public SubCourse SubCourse { get; set; }

        public string StudentFullName => $"{Student.FirstName} {Student.LastName}";
        public string SubCourseCode => SubCourse.Code;

        public string AttendanceDateShort => AttendanceDate.ToShortDateString();
    }
}
