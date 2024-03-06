using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using SchoolAutomationProject.Domain.Entities.Enums;

namespace SchoolAutomationProject.Application.ViewModels.ParentAreaViewModels.AttendanceViewModels

{
    public class ReadAttendanceViewModel : IReadViewModel
    {
        public AttendanceStatus AttendanceStatus { get; set; }
        public DateTime AttendanceDate { get; set; } 
        public string AttendanceDateShort => AttendanceDate.ToShortDateString();
        public Student Student { get; set; }
        public string StudentFullName => $"{Student.FirstName} {Student.LastName}";

        public SubCourse SubCourse { get; set; }

        public string SubCourseCode => SubCourse.Code;

    }
}
