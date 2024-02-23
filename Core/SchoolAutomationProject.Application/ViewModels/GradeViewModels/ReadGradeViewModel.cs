using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Application.ViewModels.GradeViewModels
{
    public class ReadGradeViewModel:ReadViewModel
    {
        public double Score { get; set; } // Öğrencinin aldığı not
        public byte ExamNumber { get; set; } // O dersin kaçıncı sınavı

        // Not - Öğrenci ilişkisi
        public Student Student { get; set; }

        // Not - Alt Ders ilişkisi
        public SubCourse SubCourse { get; set; }
    }
}
