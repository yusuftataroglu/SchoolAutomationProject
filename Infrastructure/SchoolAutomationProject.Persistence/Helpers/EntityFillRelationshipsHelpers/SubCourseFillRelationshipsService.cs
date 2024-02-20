using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.ViewModels.SubCourseViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Persistence.Helpers.EntityFillRelationshipsHelpers
{
    public class SubCourseFillRelationshipsService : ISubCourseFillRelationshipsService
    {
        public SubCourseFillRelationshipsService()
        {

        }
        public Task FillSubCourseRelationships(SubCourse subCourse, WriteSubCourseViewModel modelVM, string requestType)
        {
            throw new NotImplementedException();
        }
    }
}
