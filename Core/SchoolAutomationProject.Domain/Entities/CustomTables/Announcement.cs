using SchoolAutomationProject.Domain.Entities.CommonTables;
using SchoolAutomationProject.Domain.Entities.CrossTables;
using SchoolAutomationProject.Domain.Entities.IdentityTables;

namespace SchoolAutomationProject.Domain.Entities.CustomTables
{
    public class Announcement : BaseClass
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public virtual AppUser Sender { get; set; }
        public string? SenderId { get; set; }

        public virtual ICollection<AnnouncementRole> AnnouncementRoles{ get; set; }
    }
}
