using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using SchoolAutomationProject.Domain.Entities.CommonTables;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using SchoolAutomationProject.Domain.Entities.Enums;

namespace SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.AchievementViewModels
{
    public class ReadAchievementViewModel : BaseClass, IReadViewModel
    {
        public AchievementType Type { get; set; } // Belge türü (Takdir, Teşekkür)
        public string? Description { get; set; } // Belge açıklaması

        // Öğrenci - Belge ilişkisi
        public Student Student { get; set; }

        //Achievement - Semester ilişkisi
        public Semester Semester { get; set; }

        public string StudentFullName => $"{Student.FirstName} {Student.LastName}";
        public string SemesterName => Semester.Name;

    }
}
