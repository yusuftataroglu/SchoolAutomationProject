using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.Repositories.AchievementRepositories;
using SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.SemesterViewModels;
using SchoolAutomationProject.Domain.Entities.CrossTables;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Persistence.Helpers.EntityFillRelationshipsHelpers
{
    public class SemesterFillRelationshipsService : ISemesterFillRelationshipsService
    {
        private readonly IAchievementReadRepository _achievementReadRepository;

        public SemesterFillRelationshipsService(IAchievementReadRepository achievementReadRepository)
        {
            _achievementReadRepository = achievementReadRepository;
        }
        public async Task FillSemesterRelationships(Semester semester, WriteSemesterViewModel modelVM, string requestType)
        {
            if (requestType == "Add" || requestType == "UpdatePost")
            {
                semester.Name = modelVM.Name;
                semester.StartDate = modelVM.StartDate;
                semester.EndDate = modelVM.EndDate;
            }
        }
    }
}
