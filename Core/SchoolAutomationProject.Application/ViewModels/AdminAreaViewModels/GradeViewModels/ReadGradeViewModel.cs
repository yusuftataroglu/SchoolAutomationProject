using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using SchoolAutomationProject.Domain.Entities.CommonTables;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.GradeViewModels
{
    public class ReadGradeViewModel : BaseClass, IReadViewModel
    {
        public double Score { get; set; } // Öğrencinin aldığı not
        public byte ExamNumber { get; set; } // O dersin kaçıncı sınavı

        // Not - Öğrenci ilişkisi
        public Student Student { get; set; }

        // Not - Alt Ders ilişkisi
        public SubCourse SubCourse { get; set; }

        public string StudentFullName => Student.IsActive ? $"{Student.FirstName} {Student.LastName}" : "Silinmiş Öğrenci";
        public string SubCourseCode => SubCourse.IsActive ? SubCourse.Code : "Silinmiş Alt Ders";

    }
}
