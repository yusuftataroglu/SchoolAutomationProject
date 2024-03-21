using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using SchoolAutomationProject.Domain.Entities.Enums;

namespace SchoolAutomationProject.Application.ViewModels.StudentAreaViewModels.AttendanceViewModels

{
    public class ReadAttendanceViewModel : IReadViewModel
    {
        public DateTime AttendanceDate { get; set; }
        public string AttendanceDateShort => AttendanceDate.ToShortDateString();
        public AttendanceStatus AttendanceStatus { get; set; }
        public SubCourse SubCourse { get; set; }
        public string SubCourseCode => SubCourse.IsActive ? SubCourse.Code : "Silinmiş Alt Ders";

    }
}
