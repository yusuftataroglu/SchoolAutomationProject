using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.Repositories.SemesterRepositories;
using SchoolAutomationProject.Application.Repositories.StudentRepositories;
using SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.AchievementViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Persistence.Helpers.EntityFillRelationshipsHelpers
{
    public class AchievementFillRelationshipsService : IAchievementFillRelationshipsService
    {
        private readonly IStudentReadRepository _studentReadRepository;
        private readonly ISemesterReadRepository _semesterReadRepository;

        public AchievementFillRelationshipsService(IStudentReadRepository studentReadRepository, ISemesterReadRepository semesterReadRepository)
        {
            _studentReadRepository = studentReadRepository;
            _semesterReadRepository = semesterReadRepository;
        }

        public async Task FillAchievementRelationships(Achievement achievement, WriteAchievementViewModel modelVM, string requestType)
        {

            if (requestType == "Add" || requestType == "UpdatePost")
            {
                achievement.Type = modelVM.Type;
                achievement.Description = modelVM.Description;

                var student = await _studentReadRepository.GetByIdAsync(modelVM.StudentId);
                if (student != null)
                {
                    achievement.Student = student;
                }

                var semester = await _semesterReadRepository.GetByIdAsync(modelVM.SemesterId);
                if (semester != null)
                {
                    achievement.Semester = semester;
                }

            }

        }
    }
}

