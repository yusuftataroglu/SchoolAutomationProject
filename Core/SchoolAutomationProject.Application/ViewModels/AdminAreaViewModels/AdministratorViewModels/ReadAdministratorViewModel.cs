using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using SchoolAutomationProject.Domain.Entities.CommonTables;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using SchoolAutomationProject.Domain.Entities.IdentityTables;

namespace SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.AdministratorViewModels
{
    public class ReadAdministratorViewModel:BaseClass,IReadViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Title { get; set; }
        public virtual AppUser User { get; set; }
        public string? UserId { get; set; }
        public virtual ICollection<Announcement>? Announcements { get; set; }
    }
}
