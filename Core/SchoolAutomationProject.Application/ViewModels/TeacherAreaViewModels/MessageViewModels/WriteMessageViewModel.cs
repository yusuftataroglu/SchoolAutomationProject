using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using SchoolAutomationProject.Domain.Entities.IdentityTables;
using System.ComponentModel.DataAnnotations;

namespace SchoolAutomationProject.Application.ViewModels.TeacherAreaViewModels.MessageViewModels
{
    public class WriteMessageViewModel : IWriteViewModel
    {
        public Guid Id { get ; set ; }

        [Required(ErrorMessage ="Mesaj İçeriği Boş Geçilemez!")]
        public string Content { get; set; }
        public string? SenderId { get; set; }
        public string? ReceiverId { get; set; }
    }
}
