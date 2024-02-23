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
            classroom.Name = modelVM.Name;
            classroom.Capacity = modelVM.Capacity;

            if (requestType == "Add")
            {
                // İlgili ClassroomMainCourses ekleniyor
                foreach (var modelVMMainCourseId in modelVM.ClassroomMainCoursesMainCourseIds)
                {
                    var classroomMainCourse = new ClassroomMainCourse()
                    {
                        ClassroomId = classroom.Id,
                        MainCourseId = Guid.Parse(modelVMMainCourseId)
                    };
                    classroom.ClassroomMainCourses.Add(classroomMainCourse);
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
                    var classroomTeacher = new ClassroomTeacher()
                    {
                        ClassroomId = classroom.Id,
                        TeacherId = Guid.Parse(modelVMTeacherId)
                    };
                    classroom.ClassroomTeachers.Add(classroomTeacher);
                }

            }
            else if (requestType == "UpdateGet")
            {
                modelVM.StudentIds = classroom.Students.Select(x => x.Id.ToString()).ToList();
                modelVM.ClassroomMainCoursesMainCourseIds = classroom.ClassroomMainCourses.Select(x => x.MainCourseId.ToString()).ToList();
                modelVM.ClassroomTeachersTeacherIds = classroom.ClassroomTeachers.Select(x => x.TeacherId.ToString()).ToList();
            }
            else if (requestType == "UpdatePost")
            {
                classroom.ClassroomTeachers.Clear();
                classroom.ClassroomMainCourses.Clear();
                classroom.Students.Clear();

                //İlgili sınıf için modelVM'den gelen ClassroomId değerlerini ClassroomTeachers tablosuna ekliyorum.
                List<ClassroomTeacher> classroomTeachers = new();
                foreach (var teacherId in modelVM.ClassroomTeachersTeacherIds)
                {
                    classroomTeachers.Add(new ClassroomTeacher
                    {
                        ClassroomId = classroom.Id,
                        TeacherId = Guid.Parse(teacherId)
                    });
                }


                //İlgili sınıf için modelVM'dan gelen MainCourseId değerlerini ClassroomMainCourses tablosuna ekliyorum.
                List<ClassroomMainCourse> classroomMainCourses = new();
                foreach (var mainCourseId in modelVM.ClassroomMainCoursesMainCourseIds)
                {
                    classroomMainCourses.Add(new ClassroomMainCourse
                    {
                        ClassroomId = classroom.Id,
                        MainCourseId = Guid.Parse(mainCourseId)
                    });
                }


                //İlgili sınıf için modelVM'dan gelen Students değerlerini ekliyorum.
                List<Student> students = new();
                foreach (var studentId in modelVM.StudentIds)
                {
                    var student = await _studentReadRepository.GetByIdAsync(studentId.ToString());
                    students.Add(student);
                }


                //Güncellenen değerleri aktarıyorum.
                classroom.ClassroomTeachers = classroomTeachers;
                classroom.Students = students;
                classroom.ClassroomMainCourses = classroomMainCourses;
            }
        }
    }
}
