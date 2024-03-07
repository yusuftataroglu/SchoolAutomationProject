using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.Repositories.MainCourseRepositories;
using SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.TeacherViewModels;
using SchoolAutomationProject.Domain.Entities.CrossTables;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Persistence.Helpers.EntityFillRelationshipsHelpers
{
    public class TeacherFillRelationshipsService : ITeacherFillRelationshipsService
    {
        private readonly IMainCourseReadRepository _mainCourseReadRepository;

        public TeacherFillRelationshipsService(IMainCourseReadRepository mainCourseReadRepository)
        {
            _mainCourseReadRepository = mainCourseReadRepository;
        }
        public async Task FillTeacherRelationships(Teacher teacher, WriteTeacherViewModel modelVM, string requestType)
        {

            if (requestType == "Add" || requestType == "UpdatePost")
            {

                teacher.ClassroomTeachers.Clear();
                foreach (var classroomId in modelVM.ClassroomTeachersClassroomIds)
                {
                    teacher.ClassroomTeachers.Add(new ClassroomTeacher { ClassroomId = classroomId });
                }
            }
        }
    }
}
