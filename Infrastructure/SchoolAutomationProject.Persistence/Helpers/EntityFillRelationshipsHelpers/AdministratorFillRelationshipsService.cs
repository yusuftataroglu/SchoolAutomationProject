using Microsoft.AspNetCore.Identity;
using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.AdministratorViewModels;
using SchoolAutomationProject.Domain.Entities.CrossTables;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using SchoolAutomationProject.Domain.Entities.IdentityTables;

namespace SchoolAutomationProject.Persistence.Helpers.EntityFillRelationshipsHelpers
{
    public class AdministratorFillRelationshipsService : IAdministratorFillRelationshipsService
    {
        private readonly UserManager<AppUser> _userManager;

        public AdministratorFillRelationshipsService(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task FillAdministratorRelationships(Administrator admin, WriteAdministratorViewModel modelVM, string requestType)
        {
            if (requestType == "Add")
            {
                AppUser user = new AppUser
                {
                    Id = Guid.NewGuid().ToString(),
                    UserName = $"{admin.FirstName.ToLower().Trim().Replace(" ", "")}{admin.LastName.ToLower()}",
                    NormalizedUserName= $"{admin.FirstName.ToUpper().Trim().Replace(" ", "")}{admin.LastName.ToUpper()}",
                    Email = ""
                };

                await _userManager.CreateAsync(user, modelVM.Password);
                await _userManager.AddToRoleAsync(user, "Admin");

                admin.User = user;
            }
            else if (requestType == "UpdatePost")
            {
                admin.User.UserName = $"{modelVM.FirstName.ToLower().Trim().Replace(" ", "")}{modelVM.LastName.ToLower()}";
                admin.User.NormalizedUserName = $"{modelVM.FirstName.ToUpper()}{modelVM.LastName.ToUpper()}";
                await _userManager.RemovePasswordAsync(modelVM.User);
                await _userManager.AddPasswordAsync(admin.User, modelVM.Password);
            }
        }
    }
}

