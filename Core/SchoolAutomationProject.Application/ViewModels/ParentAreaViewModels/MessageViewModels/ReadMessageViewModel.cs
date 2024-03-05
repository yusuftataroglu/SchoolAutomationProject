using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using SchoolAutomationProject.Domain.Entities.IdentityTables;

namespace SchoolAutomationProject.Application.ViewModels.ParentAreaViewModels.MessageViewModels
{
    public class ReadMessageViewModel:IReadViewModel
    {
        public string Content { get; set; }
        public virtual AppUser Sender { get; set; }
        public virtual AppUser Receiver { get; set; }
    }
}
