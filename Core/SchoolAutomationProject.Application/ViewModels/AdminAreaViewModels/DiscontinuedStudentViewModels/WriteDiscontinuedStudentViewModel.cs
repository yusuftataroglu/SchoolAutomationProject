using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using System.ComponentModel.DataAnnotations;

namespace SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.DiscontinuedStudentViewModels
{
    public class WriteDiscontinuedStudentViewModel : IWriteViewModel
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Öğrenci Boş Geçilemez!")]
        public string StudentId { get; set; }
    }
}
