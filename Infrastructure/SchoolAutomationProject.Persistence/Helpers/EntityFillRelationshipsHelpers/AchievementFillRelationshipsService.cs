using Microsoft.AspNetCore.Mvc.Rendering;
using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.Repositories.SemesterRepositories;
using SchoolAutomationProject.Application.Repositories.StudentRepositories;
using SchoolAutomationProject.Application.ViewModels.AchievementViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using SchoolAutomationProject.Domain.Entities.Enums;

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
            achievement.Type = modelVM.Type;
            achievement.Description = modelVM.Description;
            if (requestType == "Add")
            {
                if (!string.IsNullOrEmpty(modelVM.StudentId))
                {
                    var student = await _studentReadRepository.GetByIdAsync(modelVM.StudentId);
                    if (student != null)
                    {
                        achievement.Student = student;
                    }
                }
                if (!string.IsNullOrEmpty(modelVM.StudentId))
                {
                    var semester = await _semesterReadRepository.GetByIdAsync(modelVM.SemesterId);
                    if (semester != null)
                    {
                        achievement.Semester = semester;
                    }
                }
            }
            else if (requestType == "UpdateGet")
            {
                modelVM.StudentId = achievement.StudentId?.ToString();
                modelVM.SemesterId = achievement.SemesterId?.ToString();
            }
            else if (requestType == "UpdatePost")
            {

                if (!string.IsNullOrEmpty(modelVM.StudentId))
                {
                    var student = await _studentReadRepository.GetByIdAsync(modelVM.StudentId);
                    if (student != null)
                    {
                        achievement.Student = student;
                    }
                }
                if (!string.IsNullOrEmpty(modelVM.SemesterId))
                {
                    var semester = await _semesterReadRepository.GetByIdAsync(modelVM.SemesterId);
                    if (semester != null)
                    {
                        achievement.Semester = semester;
                    }
                }
            }
        }
    }
}

