using SchoolAutomationProject.Application.Helpers.EntityRelationshipHelpers;
using SchoolAutomationProject.Application.Repositories.StudentRepositories;
using SchoolAutomationProject.Application.ViewModels.ClassroomViewModels;
using SchoolAutomationProject.Domain.Entities.CrossTables;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Persistence.Helpers
{
    public class FillEntityRelationshipsService : IFillEntityRelationshipsService
    {
        private readonly IStudentReadRepository _studentReadRepository;

        public FillEntityRelationshipsService(IStudentReadRepository studentReadRepository)
        {
            _studentReadRepository = studentReadRepository;
        }

        public async Task FillEntityRelationships<T, TWriteViewModel>(T entity, TWriteViewModel model)
        {
            if (typeof(T) == typeof(Classroom))
            {
                await FillClassroomRelationships(entity as Classroom, model as WriteClassroomViewModel);
            }
            ;

        }
        public async Task FillClassroomRelationships(Classroom entity, WriteClassroomViewModel model)
        {

            model.StudentIds = entity.Students.Select(x => x.Id.ToString()).ToList();
            model.ClassroomMainCoursesMainCourseIds = entity.ClassroomMainCourses.Select(x => x.MainCourseId.ToString()).ToList();
            model.ClassroomTeachersTeacherIds = entity.ClassroomTeachers.Select(x => x.TeacherId.ToString()).ToList();


            // İlgili ClassroomMainCourses ekleniyor
            foreach (var modelMainCourseId in model.ClassroomMainCoursesMainCourseIds)
            {
                var classroomMainCourse = new ClassroomMainCourse()
                {
                    ClassroomId = entity.Id,
                    MainCourseId = Guid.Parse(modelMainCourseId)
                };
                entity.ClassroomMainCourses.Add(classroomMainCourse);
            }

            // İlgili Students ekleniyor
            foreach (var modelStudentId in model.StudentIds)
            {
                var student = await _studentReadRepository.GetByIdAsync(modelStudentId.ToString());
                if (student != null)
                {
                    entity.Students.Add(student);
                }
            }

            // İlgili ClassroomTeachers ekleniyor
            foreach (var modelTeacherId in model.ClassroomTeachersTeacherIds)
            {
                var classroomTeacher = new ClassroomTeacher()
                {
                    ClassroomId = entity.Id,
                    TeacherId = Guid.Parse(modelTeacherId)
                };
                entity.ClassroomTeachers.Add(classroomTeacher);
            }
        }
    }
}
