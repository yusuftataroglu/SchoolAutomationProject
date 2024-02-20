using SchoolAutomationProject.Application.ViewModels.MainCourseViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers.MainCourseFillRelationshipsServices
{
    public interface IMainCourseFillRelationshipsService
    {
        public Task FillMainCourseRelationships(MainCourse mainCourse, WriteMainCourseViewModel modelVM, string requestType);

    }
}
