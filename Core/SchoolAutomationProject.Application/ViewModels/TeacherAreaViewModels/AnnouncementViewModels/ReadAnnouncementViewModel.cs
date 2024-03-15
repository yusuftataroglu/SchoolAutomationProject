using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using SchoolAutomationProject.Domain.Entities.CrossTables;
using SchoolAutomationProject.Domain.Entities.IdentityTables;

namespace SchoolAutomationProject.Application.ViewModels.TeacherAreaViewModels.AnnouncementViewModels
{
    public class ReadAnnouncementViewModel : IReadViewModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public AppUser Sender { get; set; }
        public ICollection<AnnouncementRole> AnnouncementRoles { get; set; }
        public string CreatedUser { get; set; }

    }
}
