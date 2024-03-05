using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Persistence.Helpers.EntityFillRelationshipsHelpers
{
    public class HomeworkFillRelationshipsService : IHomeworkFillRelationshipsService
    {

        public HomeworkFillRelationshipsService()
        {
        }

        public async Task FillHomeworkRelationshipsForStudent(Homework homework, Application.ViewModels.StudentAreaViewModels.HomeworkViewModels.WriteHomeworkViewModel modelVM, string requestType)
        {
            throw new NotImplementedException();
        }

        public async Task FillHomeworkRelationshipsForTeacher(Homework homework, Application.ViewModels.TeacherAreaViewModels.HomeworkViewModels.WriteHomeworkViewModel modelVM, string requestType)
        {
            throw new NotImplementedException();
        }
    }
}

