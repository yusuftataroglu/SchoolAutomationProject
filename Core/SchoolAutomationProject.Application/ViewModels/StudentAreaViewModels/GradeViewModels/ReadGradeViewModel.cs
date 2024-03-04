using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Application.ViewModels.StudentAreaViewModels.GradeViewModels
{
    public class ReadGradeViewModel : IReadViewModel
    {
        public double Score { get; set; }
        public byte ExamNumber { get; set; }
        public SubCourse SubCourse { get; set; }
        public string SubCourseCode => SubCourse.Code;

    }
}
