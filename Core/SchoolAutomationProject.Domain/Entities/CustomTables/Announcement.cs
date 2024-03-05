using SchoolAutomationProject.Domain.Entities.CommonTables;
using SchoolAutomationProject.Domain.Entities.CrossTables;

namespace SchoolAutomationProject.Domain.Entities.CustomTables
{
    public class Announcement : BaseClass
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public Guid CreatorId { get; set; }
        public virtual Administrator? Admin { get; set; }
        public virtual Teacher? Teacher { get; set; }
        public virtual ICollection<AnnouncementRole> AnnouncementRoles{ get; set; }
    }
}
