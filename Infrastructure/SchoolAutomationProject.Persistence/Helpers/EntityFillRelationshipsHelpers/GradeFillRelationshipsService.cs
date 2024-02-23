using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.Repositories.StudentRepositories;
using SchoolAutomationProject.Application.Repositories.SubCourseRepositories;
using SchoolAutomationProject.Application.ViewModels.GradeViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Persistence.Helpers.EntityFillRelationshipsHelpers
{
    public class GradeFillRelationshipsService : IGradeFillRelationshipsService
    {
        private readonly IStudentReadRepository _studentReadRepository;
        private readonly ISubCourseReadRepository _subCourseReadRepository;

        public GradeFillRelationshipsService(IStudentReadRepository studentReadRepository, ISubCourseReadRepository subCourseReadRepository)
        {
            _studentReadRepository = studentReadRepository;
            _subCourseReadRepository = subCourseReadRepository;
        }

        public async Task FillGradeRelationships(Grade grade, WriteGradeViewModel modelVM, string requestType)
        {
            grade.Score = modelVM.Score;
            grade.ExamNumber = modelVM.ExamNumber;

            if (requestType == "Add" || requestType == "UpdatePost")
            {
                if (!string.IsNullOrEmpty(modelVM.StudentId))
                {
                    var student = await _studentReadRepository.GetByIdAsync(modelVM.StudentId);
                    if (student != null)
                    {
                        grade.Student = student;
                    }
                }

                if (!string.IsNullOrEmpty(modelVM.SubCourseId))
                {
                    var subCourse = await _subCourseReadRepository.GetByIdAsync(modelVM.SubCourseId);
                    if (subCourse != null)
                    {
                        grade.SubCourse = subCourse;
                    }
                }
            }
            else if (requestType == "UpdateGet")
            {
                modelVM.StudentId = grade.StudentId?.ToString();
                modelVM.SubCourseId = grade.SubCourseId?.ToString();
            }
        }
    }
}

