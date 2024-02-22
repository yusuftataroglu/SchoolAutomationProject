using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using System.ComponentModel.DataAnnotations;

namespace SchoolAutomationProject.Application.ViewModels.GradeViewModels
{
    public class WriteGradeViewModel:WriteViewModel
    {
        [Required(ErrorMessage = "Not Boş Geçilemez!")]
        public double Score { get; set; } // Öğrencinin aldığı not
        [Required(ErrorMessage ="Sınav Numarası Boş Geçilemez!")]
        public byte ExamNumber { get; set; } // O dersin kaçıncı sınavı

        // Not - Öğrenci ilişkisi
        [Required(ErrorMessage ="Öğrenci Boş Geçilemez!")]
        public string StudentId { get; set; } // Öğrenci ID'si

        // Not - Alt Ders ilişkisi
        [Required(ErrorMessage ="Alt Ders Boş Geçilemez!")]
        public string SubCourseId { get; set; } // Ana Ders ID'si
    }
}
