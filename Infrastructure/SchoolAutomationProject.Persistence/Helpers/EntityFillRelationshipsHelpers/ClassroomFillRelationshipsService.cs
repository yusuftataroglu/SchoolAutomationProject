using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.Repositories.StudentRepositories;
using SchoolAutomationProject.Application.ViewModels.ClassroomViewModels;
using SchoolAutomationProject.Domain.Entities.CrossTables;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Persistence.Helpers.EntityFillRelationshipsHelpers
{
    public class ClassroomFillRelationshipsService : IClassroomFillRelationshipsService
    {
        private readonly IStudentReadRepository _studentReadRepository;

        public ClassroomFillRelationshipsService(IStudentReadRepository studentReadRepository)
        {
            _studentReadRepository = studentReadRepository;
        }
        public async Task FillClassroomRelationships(Classroom classroom, WriteClassroomViewModel modelVM, string requestType)
        {
            if (requestType == "Add" || requestType == "UpdatePost")
            {
                classroom.Name = modelVM.Name;
                classroom.Capacity = modelVM.Capacity;

                if (classroom.ClassroomMainCourses != null)
                {
                    classroom.ClassroomMainCourses.Clear();
                }
                if (classroom.ClassroomTeachers != null)
                {
                    classroom.ClassroomTeachers.Clear();
                }
                if (classroom.Students != null)
                {
                    classroom.Students.Clear();
                }
                // İlgili ClassroomMainCourses ekleniyor
                foreach (var modelVMMainCourseId in modelVM.ClassroomMainCoursesMainCourseIds)
                {
                    classroom.ClassroomMainCourses.Add(new ClassroomMainCourse { ClassroomId = classroom.Id, MainCourseId = Guid.Parse(modelVMMainCourseId) });
                }

                // İlgili Students ekleniyor
                foreach (var modelVMStudentId in modelVM.StudentIds)
                {
                    var student = await _studentReadRepository.GetByIdAsync(modelVMStudentId.ToString());
                    if (student != null)
                    {
                        classroom.Students.Add(student);
                    }
                }

                // İlgili ClassroomTeachers ekleniyor
                foreach (var modelVMTeacherId in modelVM.ClassroomTeachersTeacherIds)
                {
                    classroom.ClassroomTeachers.Add(new ClassroomTeacher { ClassroomId = classroom.Id, TeacherId = Guid.Parse(modelVMTeacherId) });
                }

            }
            else if (requestType == "UpdateGet")
            {
                modelVM.StudentIds = classroom.Students.Select(x => x.Id.ToString()).ToList();
                modelVM.ClassroomMainCoursesMainCourseIds = classroom.ClassroomMainCourses.Select(x => x.MainCourseId.ToString()).ToList();
                modelVM.ClassroomTeachersTeacherIds = classroom.ClassroomTeachers.Select(x => x.TeacherId.ToString()).ToList();
            }
        }
    }
}
