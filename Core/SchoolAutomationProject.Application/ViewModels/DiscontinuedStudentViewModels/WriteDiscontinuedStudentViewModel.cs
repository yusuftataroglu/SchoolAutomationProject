using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using System.ComponentModel.DataAnnotations;

namespace SchoolAutomationProject.Application.ViewModels.DiscontinuedStudentViewModels
{
    public class WriteDiscontinuedStudentViewModel:WriteViewModel
    {
        [Required(ErrorMessage ="Öğrenci Boş Geçilemez!")]
        public string StudentId { get; set; }
    }
}
