using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.Repositories.StudentRepositories;
using SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.ParentViewModels;
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
                parent.FirstName = modelVM.FirstName;
                parent.LastName = modelVM.LastName;
                parent.MobilePhone = modelVM.MobilePhone;
                parent.WorkPhone = modelVM.WorkPhone;
                parent.Address = modelVM.Address;
                parent.District = modelVM.District;
                parent.City = modelVM.City;

                parent.Students.Clear();
                foreach (var studentId in modelVM.StudentIds)
                {
                    var student = await _studentReadRepository.GetByIdAsync(studentId);
                    parent.Students.Add(student);
                }
            }
        }
    }
}
