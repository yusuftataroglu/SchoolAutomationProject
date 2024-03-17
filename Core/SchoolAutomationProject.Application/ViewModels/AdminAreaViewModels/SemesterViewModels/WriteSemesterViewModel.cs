using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using System.ComponentModel.DataAnnotations;

namespace SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.SemesterViewModels
{
    public class WriteSemesterViewModel : IWriteViewModel
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Dönem Adı Boş Geçilemez!")]
        public string Name { get; set; } // Örneğin "2022-2023 Spring Season"

        [Required(ErrorMessage = "Dönem Başlangıç Tarihi Boş Geçilemez!")]
        public DateTime? StartDate { get; set; }

        [Required(ErrorMessage = "Dönem Bitiş Tarihi Boş Geçilemez!")]
        public DateTime? EndDate { get; set; }
    }
}
