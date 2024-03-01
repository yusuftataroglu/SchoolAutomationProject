using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.Repositories.StudentRepositories;
using SchoolAutomationProject.Application.Repositories.SubCourseRepositories;
using SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.GradeViewModels;
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
            if (requestType == "Add" || requestType == "UpdatePost")
            {
                grade.Score = modelVM.Score;
                grade.ExamNumber = modelVM.ExamNumber;

                var student = await _studentReadRepository.GetByIdAsync(modelVM.StudentId);
                if (student != null)
                {
                    grade.Student = student;
                }

                var subCourse = await _subCourseReadRepository.GetByIdAsync(modelVM.SubCourseId);
                if (subCourse != null)
                {
                    grade.SubCourse = subCourse;
                }

            }
        }
    }
}

