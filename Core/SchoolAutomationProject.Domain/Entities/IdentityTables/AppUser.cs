using Microsoft.AspNetCore.Identity;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Domain.Entities.IdentityTables
{
    public class AppUser:IdentityUser<string>
    {
        public virtual Student Student { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
