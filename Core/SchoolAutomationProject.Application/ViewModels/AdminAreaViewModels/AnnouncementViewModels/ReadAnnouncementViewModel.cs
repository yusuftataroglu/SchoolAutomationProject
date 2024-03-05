using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using SchoolAutomationProject.Domain.Entities.CommonTables;
using SchoolAutomationProject.Domain.Entities.IdentityTables;

namespace SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.AnnouncementViewModels
{
    public class ReadAnnouncementViewModel:BaseClass,IReadViewModel
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public AppUser Sender { get; set; }
    }
}
