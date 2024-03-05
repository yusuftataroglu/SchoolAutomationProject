using SchoolAutomationProject.Domain.Entities.CommonTables;
using SchoolAutomationProject.Domain.Entities.IdentityTables;

namespace SchoolAutomationProject.Domain.Entities.CustomTables
{
    public class Message : BaseClass
    {
        public string Content { get; set; }
        public virtual AppUser Sender { get; set; }
        public virtual AppUser Receiver { get; set; }
        public string? SenderId { get; set; }
        public string? ReceiverId { get; set; }
    }
}
