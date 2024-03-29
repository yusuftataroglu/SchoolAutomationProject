using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.Repositories.StudentRepositories;
using SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.ParentViewModels;
using SchoolAutomationProject.Domain.Entities.CrossTables;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using SchoolAutomationProject.Domain.Entities.IdentityTables;

namespace SchoolAutomationProject.Persistence.Helpers.EntityFillRelationshipsHelpers
{
    public class ParentFillRelationshipsService : IParentFillRelationshipsService
    {
        private readonly IStudentReadRepository _studentReadRepository;
        private readonly UserManager<AppUser> _userManager;

        public ParentFillRelationshipsService(IStudentReadRepository studentReadRepository, UserManager<AppUser> userManager)
        {
            _studentReadRepository = studentReadRepository;
            _userManager = userManager;
        }
        public async Task FillParentRelationships(Parent parent, WriteParentViewModel modelVM, string requestType)
        {
            if (requestType == "Add")
            {
                AppUser user = new AppUser
                {
                    Id = Guid.NewGuid().ToString(),
                    UserName = $"{parent.FirstName.ToLower().Trim().Replace(" ", "")}{parent.LastName.ToLower()}",
                    NormalizedUserName = $"{parent.FirstName.ToUpper().Trim().Replace(" ", "")}{parent.LastName.ToUpper()}",
                    Email = ""
                };

                var result = await _userManager.CreateAsync(user, $"{parent.FirstName.ToLower().Trim().Replace(" ", "")}{parent.LastName.ToLower()}");
                if (result.Succeeded)
                {
                    var addRoleResult = await _userManager.AddToRoleAsync(user, "Parent");
                }
                parent.User = user;

                foreach (var studentId in modelVM.StudentIds)
                {
                    Student student = await _studentReadRepository.GetWhere(x => x.Id == studentId).FirstOrDefaultAsync();
                    parent.Students.Add(student);
                }
            }
            else if (requestType == "UpdatePost")
            {
                parent.Students.Clear();
                foreach (var studentId in modelVM.StudentIds)
                {
                    Student student = await _studentReadRepository.GetWhere(x => x.Id == studentId).FirstOrDefaultAsync();
                    parent.Students.Add(student);
                }
            }
        }
    }
}
