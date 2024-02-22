using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using SchoolAutomationProject.Domain.Entities.Enums;
using System.ComponentModel.DataAnnotations;

namespace SchoolAutomationProject.Application.ViewModels.AchievementViewModels
{
    public class ReadAchievementViewModel:ReadViewModel
    {
        public AchievementType Type { get; set; } // Belge türü (Takdir, Teşekkür)
        public string? Description { get; set; } // Belge açıklaması

        // Öğrenci - Belge ilişkisi
        public virtual Student Student { get; set; }

        //Achievement - Semester ilişkisi
        public virtual Semester Semester { get; set; }
    }
}
