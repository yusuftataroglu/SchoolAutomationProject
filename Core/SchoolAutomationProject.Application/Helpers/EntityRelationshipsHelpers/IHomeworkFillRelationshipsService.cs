using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers
{
    public interface IHomeworkFillRelationshipsService
    {
        Task FillHomeworkRelationshipsForTeacher(Homework homework, ViewModels.TeacherAreaViewModels.HomeworkViewModels.WriteHomeworkViewModel modelVM, string requestType);
        Task FillHomeworkRelationshipsForStudent(Homework homework, ViewModels.StudentAreaViewModels.HomeworkViewModels.WriteHomeworkViewModel modelVM, string requestType);
    }
}
