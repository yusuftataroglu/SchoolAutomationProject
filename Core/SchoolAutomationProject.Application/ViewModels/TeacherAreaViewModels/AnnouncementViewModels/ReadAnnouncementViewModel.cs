using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using SchoolAutomationProject.Domain.Entities.IdentityTables;

namespace SchoolAutomationProject.Application.ViewModels.TeacherAreaViewModels.AnnouncementViewModels
{
    public class ReadAnnouncementViewModel : IReadViewModel
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public AppUser Sender { get; set; }
    }
}
