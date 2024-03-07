using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using SchoolAutomationProject.Domain.Entities.Enums;
using System.ComponentModel.DataAnnotations;

namespace SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.AchievementViewModels
{
    public class WriteAchievementViewModel : IWriteViewModel
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Belge Türü Boş Geçilemez!")]
        public AchievementType Type { get; set; } // Belge türü (Takdir, Teşekkür)
        public string? Description { get; set; } // Belge açıklaması

        // Öğrenci - Belge ilişkisi
        [Required(ErrorMessage = "Öğrenci Boş Geçilemez!")]
        public Guid? StudentId { get; set; }

        //Achievement - Semester ilişkisi
        [Required(ErrorMessage = "Dönem Boş Geçilemez!")]
        public Guid? SemesterId { get; set; }
    }
}
