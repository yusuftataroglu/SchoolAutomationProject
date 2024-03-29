using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using SchoolAutomationProject.Domain.Entities.CommonTables;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Application.ViewModels.ParentAreaViewModels.GradeViewModels
{
    public class ReadGradeViewModel : BaseClass, IReadViewModel
    {
        public double Score { get; set; } 
        public byte ExamNumber { get; set; } 

        public Student Student { get; set; }

        public SubCourse SubCourse { get; set; }

        public string StudentFullName => Student.IsActive ? $"{Student.FirstName} {Student.LastName}" : "Silinmiş Öğrenci";
        public string SubCourseCode => SubCourse.IsActive ? SubCourse.Code : "Silinmiş Alt Ders";

    }
}
