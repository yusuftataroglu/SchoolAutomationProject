using Microsoft.AspNetCore.Identity;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Domain.Entities.IdentityTables
{
    public class AppUser : IdentityUser<string>
    {
        public virtual Administrator Administrator { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual Student Student { get; set; }
        public virtual Parent Parent { get; set; }

        // Kullanıcının gönderdiği mesajlar için navigation property
        public virtual ICollection<Message> SentMessages { get; set; }

        // Kullanıcının aldığı mesajlar için navigation property
        public virtual ICollection<Message> ReceivedMessages { get; set; }
    }
}
