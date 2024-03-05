using Microsoft.AspNetCore.Identity;
using SchoolAutomationProject.Domain.Entities.CrossTables;

namespace SchoolAutomationProject.Domain.Entities.IdentityTables
{
    public class AppUserRole : IdentityRole<string>
    {
        public virtual ICollection<AnnouncementRole> AnnouncementRoles { get; set; }
    }
}
