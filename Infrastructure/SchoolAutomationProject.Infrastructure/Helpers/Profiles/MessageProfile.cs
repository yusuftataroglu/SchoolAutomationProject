using AutoMapper;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Infrastructure.Helpers.Profiles
{
    public class MessageProfile:Profile
    {
        public MessageProfile()
        {
            CreateMap<Message, Application.ViewModels.AdminAreaViewModels.MessageViewModels.ReadMessageViewModel>();
            CreateMap<Application.ViewModels.AdminAreaViewModels.MessageViewModels.ReadMessageViewModel, Message>();
            CreateMap<Message, Application.ViewModels.AdminAreaViewModels.MessageViewModels.WriteMessageViewModel>();
            CreateMap<Application.ViewModels.AdminAreaViewModels.MessageViewModels.WriteMessageViewModel, Message>();

            CreateMap<Message, Application.ViewModels.TeacherAreaViewModels.MessageViewModels.ReadMessageViewModel>();
            CreateMap<Application.ViewModels.TeacherAreaViewModels.MessageViewModels.ReadMessageViewModel, Message>();
            CreateMap<Message, Application.ViewModels.TeacherAreaViewModels.MessageViewModels.WriteMessageViewModel>();
            CreateMap<Application.ViewModels.TeacherAreaViewModels.MessageViewModels.WriteMessageViewModel, Message>();

            CreateMap<Message, Application.ViewModels.ParentAreaViewModels.MessageViewModels.ReadMessageViewModel>();
            CreateMap<Application.ViewModels.ParentAreaViewModels.MessageViewModels.ReadMessageViewModel, Message>();
            CreateMap<Message, Application.ViewModels.ParentAreaViewModels.MessageViewModels.WriteMessageViewModel>();
            CreateMap<Application.ViewModels.ParentAreaViewModels.MessageViewModels.WriteMessageViewModel, Message>();

            CreateMap<Message, Application.ViewModels.StudentAreaViewModels.MessageViewModels.ReadMessageViewModel>();
            CreateMap<Application.ViewModels.StudentAreaViewModels.MessageViewModels.ReadMessageViewModel, Message>();
            CreateMap<Message, Application.ViewModels.StudentAreaViewModels.MessageViewModels.WriteMessageViewModel>();
            CreateMap<Application.ViewModels.StudentAreaViewModels.MessageViewModels.WriteMessageViewModel, Message>();
        }
    }
}
