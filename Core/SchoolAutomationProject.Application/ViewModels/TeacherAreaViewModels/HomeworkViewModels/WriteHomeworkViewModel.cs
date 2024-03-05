using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using System.ComponentModel.DataAnnotations;

namespace SchoolAutomationProject.Application.ViewModels.TeacherAreaViewModels.HomeworkViewModels
{
    public class WriteHomeworkViewModel : IWriteViewModel
    {
        public Guid Id { get ; set ; }

        [Required(ErrorMessage ="Ödev Başlığı Boş Geçilemez!")]
        public string Title { get; set; }
        public string? Description { get; set; }
        public string FileUrl { get; set; } //todo otomatik olarak atanacak
        public Guid? StudentId { get; set; }
        public Guid? SubCourseId { get; set; }
    }
}
