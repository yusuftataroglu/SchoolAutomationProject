using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.Repositories.StudentRepositories;
using SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.ParentViewModels;
using SchoolAutomationProject.Domain.Entities.CrossTables;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Persistence.Helpers.EntityFillRelationshipsHelpers
{
    public class ParentFillRelationshipsService : IParentFillRelationshipsService
    {
        private readonly IStudentReadRepository _studentReadRepository;

        public ParentFillRelationshipsService(IStudentReadRepository studentReadRepository)
        {
            _studentReadRepository = studentReadRepository;
        }
        public async Task FillParentRelationships(Parent parent, WriteParentViewModel modelVM, string requestType)
        {
            if (requestType == "Add" || requestType == "UpdatePost")
            {
                parent.Students.Clear();
                foreach (var studentId in modelVM.StudentIds)
                {
                    parent.Students.Add(new Student { Id = studentId});
                }
            }
        }
    }
}
