using SchoolAutomationProject.Domain.Entities.CommonTables;
using SchoolAutomationProject.Domain.Entities.IdentityTables;

namespace SchoolAutomationProject.Domain.Entities.CustomTables
{
    public class Administrator : BaseClass
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Title { get; set; }
        public virtual AppUser User { get; set; }
        public string? UserId { get; set; }
    }
}
