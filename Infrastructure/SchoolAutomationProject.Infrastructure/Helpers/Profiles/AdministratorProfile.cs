using AutoMapper;
using SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.AdministratorViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Infrastructure.Helpers.Profiles
{
    public class AdministratorProfile:Profile
    {
        public AdministratorProfile()
        {
            CreateMap<Administrator, ReadAdministratorViewModel>();
            CreateMap<ReadAdministratorViewModel, Administrator>();
            CreateMap<WriteAdministratorViewModel, Administrator>();
            CreateMap<Administrator, WriteAdministratorViewModel>();
        }
    }
}
