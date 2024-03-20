using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using SchoolAutomationProject.Domain.Entities.IdentityTables;

namespace SchoolAutomationProject.Application.ViewModels.ParentAreaViewModels.MessageViewModels
{
    public class ReadMessageViewModel:IReadViewModel
    {
        public Guid Id { get; set; }
        public string Content { get; set; }
        public virtual AppUser Sender { get; set; }
        public string SenderFullName => Sender.UserName;
        public virtual AppUser Receiver { get; set; }
        public string ReceiverFullName => Receiver.UserName;

    }
}
