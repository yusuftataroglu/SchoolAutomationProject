using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.Repositories.ClassroomRepositories;
using SchoolAutomationProject.Application.Repositories.SubCourseRepositories;
using SchoolAutomationProject.Application.Repositories.TeacherRepositories;
using SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.MainCourseViewModels;
using SchoolAutomationProject.Domain.Entities.CrossTables;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Persistence.Helpers.EntityFillRelationshipsHelpers
{
    public class MainCourseFillRelationshipsService : IMainCourseFillRelationshipsService
    {
        private readonly ITeacherReadRepository _teacherReadRepository;
        private readonly ISubCourseReadRepository _subCourseReadRepository;

        public MainCourseFillRelationshipsService(
            ITeacherReadRepository teacherReadRepository,
            ISubCourseReadRepository subCourseReadRepository)
        {
            _teacherReadRepository = teacherReadRepository;
            _subCourseReadRepository = subCourseReadRepository;
        }

        public async Task FillMainCourseRelationships(MainCourse mainCourse, WriteMainCourseViewModel modelVM, string requestType)
        {

            if (requestType == "Add" || requestType == "UpdatePost")
            {
                mainCourse.Name = modelVM.Name;

                mainCourse.ClassroomMainCourses.Clear();
                foreach (var modelVMClassroomId in modelVM.ClassroomMainCoursesClassroomIds)
                {
                    var classroomMainCourse = new ClassroomMainCourse()
                    {
                        MainCourseId = mainCourse.Id,
                        ClassroomId = Guid.Parse(modelVMClassroomId)
                    };
                    mainCourse.ClassroomMainCourses.Add(classroomMainCourse);
                }
            }
        }
    }
}
