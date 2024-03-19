using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using SchoolAutomationProject.Domain.Entities.Enums;

namespace SchoolAutomationProject.Application.ViewModels.TeacherAreaViewModels.AttendanceViewModels

{
    public class ReadAttendanceViewModel : IReadViewModel
    {
        public Guid Id { get; set; }
        public string CreatedUser { get; set; }
        public DateTime AttendanceDate { get; set; } 
        public AttendanceStatus AttendanceStatus { get; set; }

        // Devamsızlık - Öğrenci ilişkisi
        public Student Student { get; set; }

        // Devamsızlık - Ders ilişkisi
        public SubCourse SubCourse { get; set; }

        public string StudentFullName => Student.IsActive ? $"{Student.FirstName} {Student.LastName}" : "Silinmiş Öğrenci";
        public string SubCourseCode => SubCourse.IsActive ? SubCourse.Code : "Silinmiş Alt Ders";

        public string AttendanceDateShort => AttendanceDate.ToShortDateString();
    }
}
