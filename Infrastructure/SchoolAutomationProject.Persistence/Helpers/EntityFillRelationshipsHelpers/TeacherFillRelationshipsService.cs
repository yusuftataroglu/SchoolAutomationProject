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
                teacher.FirstName = modelVM.FirstName;
                teacher.LastName = modelVM.LastName;
                teacher.Title = modelVM.Title;

                var mainCourse = await _mainCourseReadRepository.GetByIdAsync(modelVM.MainCourseId);
                if (mainCourse != null)
                {
                    teacher.MainCourse = mainCourse;
                }

                teacher.ClassroomTeachers.Clear();
                foreach (var classroomId in modelVM.ClassroomTeachersClassroomIds)
                {
                    var classroomTeacher = new ClassroomTeacher()
                    {
                        ClassroomId = Guid.Parse(classroomId),
                        TeacherId = teacher.Id
                    };
                    teacher.ClassroomTeachers.Add(classroomTeacher);
                }
            }
        }
    }
}
