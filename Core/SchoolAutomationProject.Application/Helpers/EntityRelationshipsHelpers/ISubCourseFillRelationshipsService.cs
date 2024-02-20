using SchoolAutomationProject.Application.ViewModels.SubCourseViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers
{
    public interface ISubCourseFillRelationshipsService
    {
        public Task FillSubCourseRelationships(SubCourse subCourse, WriteSubCourseViewModel modelVM, string requestType);
    }
}
