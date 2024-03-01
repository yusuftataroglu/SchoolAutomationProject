using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.Repositories.StudentRepositories;
using SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.ClassroomViewModels;
using SchoolAutomationProject.Domain.Entities.CrossTables;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Persistence.Helpers.EntityFillRelationshipsHelpers
{
    public class ClassroomFillRelationshipsService : IClassroomFillRelationshipsService
    {
        private readonly IStudentReadRepository _studentReadRepository;

        public ClassroomFillRelationshipsService(IStudentReadRepository studentReadRepository)
        {
            _studentReadRepository = studentReadRepository;
        }
        public async Task FillClassroomRelationships(Classroom classroom, WriteClassroomViewModel modelVM, string requestType)
        {
            if (requestType == "Add" || requestType == "UpdatePost")
            {
                classroom.Name = modelVM.Name;
                classroom.Capacity = modelVM.Capacity;
            }
        }
    }
}
