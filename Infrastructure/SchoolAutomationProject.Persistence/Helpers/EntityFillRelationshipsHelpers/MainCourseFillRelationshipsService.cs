using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.Repositories.ClassroomRepositories;
using SchoolAutomationProject.Application.Repositories.SubCourseRepositories;
using SchoolAutomationProject.Application.Repositories.TeacherRepositories;
using SchoolAutomationProject.Application.ViewModels.MainCourseViewModels;
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
            mainCourse.Name = modelVM.Name;

            if (requestType == "Add")
            {
                // İlgili Teachers ekleniyor
                foreach (var teacherId in modelVM.TeacherIds)
                {
                    var teacher = await _teacherReadRepository.GetByIdAsync(teacherId.ToString());
                    if (teacher != null)
                    {
                        mainCourse.Teachers.Add(teacher);
                    }
                }


                // İlgili SubCourses ekleniyor
                foreach (var modelVMStudentId in modelVM.SubCourseIds)
                {
                    var subCourse = await _subCourseReadRepository.GetByIdAsync(modelVMStudentId.ToString());
                    if (subCourse != null)
                    {
                        mainCourse.SubCourses.Add(subCourse);
                    }
                }


                // İlgili ClassroomMainCourses ekleniyor
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
            else if (requestType == "UpdateGet")
            {
                modelVM.TeacherIds = mainCourse.Teachers.Select(x => x.Id.ToString()).ToList();
                modelVM.ClassroomMainCoursesClassroomIds = mainCourse.ClassroomMainCourses.Select(x => x.ClassroomId.ToString()).ToList();
                modelVM.SubCourseIds = mainCourse.SubCourses.Select(x => x.Id.ToString()).ToList();
            }
            else if (requestType == "UpdatePost")
            {
                // İlgili Teachers değerleri kaldırılıyor
                mainCourse.Teachers.Clear();

                // İlgili ClassroomMainCourses değerleri kaldırılıyor
                mainCourse.ClassroomMainCourses.Clear();

                // İlgili SubCourses değerleri kaldırılıyor
                mainCourse.SubCourses.Clear();

                // İlgili Teachers ekleniyor
                foreach (var teacherId in modelVM.TeacherIds)
                {
                    var teacher = await _teacherReadRepository.GetByIdAsync(teacherId.ToString());
                    if (teacher != null)
                    {
                        mainCourse.Teachers.Add(teacher);
                    }
                }

                // İlgili ClassroomMainCourses ekleniyor
                foreach (var modelVMClassroomId in modelVM.ClassroomMainCoursesClassroomIds)
                {
                    var classroomMainCourse = new ClassroomMainCourse()
                    {
                        MainCourseId = mainCourse.Id,
                        ClassroomId = Guid.Parse(modelVMClassroomId)
                    };
                    mainCourse.ClassroomMainCourses.Add(classroomMainCourse);
                }

                // İlgili SubCourses ekleniyor
                foreach (var subCourseId in modelVM.SubCourseIds)
                {
                    var subCourse = await _subCourseReadRepository.GetByIdAsync(subCourseId.ToString());
                    if (subCourse != null)
                    {
                        mainCourse.SubCourses.Add(subCourse);
                    }
                }
            }
        }
    }
}
