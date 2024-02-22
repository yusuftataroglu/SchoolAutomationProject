using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using System.ComponentModel.DataAnnotations;

namespace SchoolAutomationProject.Application.ViewModels.SemesterViewModels
{
    public class WriteSemesterViewModel:WriteViewModel
    {
        public WriteSemesterViewModel()
        {
            AchievementIds = new();    
        }

        [Required(ErrorMessage = "Dönem Adı Boş Geçilemez!")]
        public string Name { get; set; } // Örneğin "2022-2023 Spring Season"

        [Required(ErrorMessage ="Dönem Başlangıç Tarihi Boş Geçilemez!")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage ="Dönem Bitiş Tarihi Boş Geçilemez!")]
        public DateTime EndDate { get; set; }

        //Semester - Achievement ilişkisi
        public List<string>? AchievementIds { get; set; }
    }
}
