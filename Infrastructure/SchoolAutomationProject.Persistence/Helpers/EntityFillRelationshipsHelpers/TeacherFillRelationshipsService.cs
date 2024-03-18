using Microsoft.AspNetCore.Identity;
using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.TeacherViewModels;
using SchoolAutomationProject.Domain.Entities.CrossTables;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using SchoolAutomationProject.Domain.Entities.IdentityTables;

namespace SchoolAutomationProject.Persistence.Helpers.EntityFillRelationshipsHelpers
{
    public class TeacherFillRelationshipsService : ITeacherFillRelationshipsService
    {
        private readonly UserManager<AppUser> _userManager;

        public TeacherFillRelationshipsService(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task FillTeacherRelationships(Teacher teacher, WriteTeacherViewModel modelVM, string requestType)
        {

            if (requestType == "Add")
            {
                AppUser user = new AppUser
                {
                    Id = Guid.NewGuid().ToString(),
                    UserName = $"{teacher.FirstName.ToUpper()}{teacher.LastName.ToUpper()}",
                    Email=""
                };

                await _userManager.CreateAsync(user, $"{teacher.FirstName.ToUpper()}{teacher.LastName.ToUpper()}");
                await _userManager.AddToRoleAsync(user, "Teacher");

                teacher.User = user;

                foreach (var classroomId in modelVM.ClassroomTeachersClassroomIds)
                {
                    teacher.ClassroomTeachers.Add(new ClassroomTeacher { ClassroomId = classroomId });
                }
            }
            else if (requestType == "UpdatePost")
            {
                teacher.ClassroomTeachers.Clear();
                foreach (var classroomId in modelVM.ClassroomTeachersClassroomIds)
                {
                    teacher.ClassroomTeachers.Add(new ClassroomTeacher { ClassroomId = classroomId });
                }
            }
        }
    }
}
