using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using SchoolAutomationProject.Domain.Entities.Enums;

namespace SchoolAutomationProject.Application.ViewModels.AchievementViewModels
{
    public class ReadAchievementViewModel:ReadViewModel
    {
        public AchievementType Type { get; set; } // Belge türü (Takdir, Teşekkür)
        public string? Description { get; set; } // Belge açıklaması

        // Öğrenci - Belge ilişkisi
        public Student Student { get; set; }

        //Achievement - Semester ilişkisi
        public Semester Semester { get; set; }
    }
}
