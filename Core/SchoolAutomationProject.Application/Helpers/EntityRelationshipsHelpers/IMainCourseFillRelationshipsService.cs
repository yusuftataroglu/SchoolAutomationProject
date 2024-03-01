using SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.MainCourseViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers
{
    public interface IMainCourseFillRelationshipsService
    {
        public Task FillMainCourseRelationships(MainCourse mainCourse, WriteMainCourseViewModel modelVM, string requestType);

    }
}
