using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using System.ComponentModel.DataAnnotations;

namespace SchoolAutomationProject.Application.ViewModels.StudentAreaViewModels.HomeworkViewModels
{
    public class WriteHomeworkViewModel : IWriteViewModel
    {
        public Guid Id { get ; set ; }

        [Required(ErrorMessage ="Ödev Başlığı Boş Geçilemez!")]
        public string Title { get; set; }
        public string? Description { get; set; }
        public string? FileUrl { get; set; } 
        public Guid? StudentId { get; set; }
        public Guid? SubCourseId { get; set; }
    }
}
