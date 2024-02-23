using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using SchoolAutomationProject.Domain.Entities.Enums;
using System.ComponentModel.DataAnnotations;

namespace SchoolAutomationProject.Application.ViewModels.AchievementViewModels
{
    public class WriteAchievementViewModel:WriteViewModel
    {

        [Required(ErrorMessage ="Belge Türü Boş Geçilemez!")]
        public AchievementType Type { get; set; } // Belge türü (Takdir, Teşekkür)
        public string? Description { get; set; } // Belge açıklaması

        // Öğrenci - Belge ilişkisi
        [Required(ErrorMessage ="Öğrenci Boş Geçilemez!")]
        public string StudentId { get; set; }

        //Achievement - Semester ilişkisi
        [Required(ErrorMessage ="Dönem Boş Geçilemez!")]
        public string SemesterId { get; set; }
    }
}
