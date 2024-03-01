using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.Repositories.MainCourseRepositories;
using SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.SubCourseViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using System.Diagnostics;

namespace SchoolAutomationProject.Persistence.Helpers.EntityFillRelationshipsHelpers
{
    public class SubCourseFillRelationshipsService : ISubCourseFillRelationshipsService
    {
        private readonly IMainCourseReadRepository _mainCourseReadRepository;

        public SubCourseFillRelationshipsService(IMainCourseReadRepository mainCourseReadRepository)
        {
            _mainCourseReadRepository = mainCourseReadRepository;
        }
        public async Task FillSubCourseRelationships(SubCourse subCourse, WriteSubCourseViewModel modelVM, string requestType)
        {
            if (requestType == "Add" || requestType == "UpdatePost")
            {
                subCourse.Code = modelVM.Code;
                subCourse.WeeklyHour = modelVM.WeeklyHour;
                subCourse.Position = modelVM.Position;

                var mainCourse = await _mainCourseReadRepository.GetByIdAsync(modelVM.MainCourseId);
                if (mainCourse != null)
                {
                    subCourse.MainCourse = mainCourse;
                }
            }
        }
    }
}
