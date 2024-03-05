using SchoolAutomationProject.Domain.Entities.CustomTables;
using SchoolAutomationProject.Domain.Entities.IdentityTables;

namespace SchoolAutomationProject.Domain.Entities.CrossTables
{
    public class AnnouncementRole
    {
        public virtual AppUserRole Role { get; set; }
        public virtual Announcement Announcement { get; set; }
        public string RoleId { get; set; }
        public Guid AnnouncementId { get; set; }
    }

}
