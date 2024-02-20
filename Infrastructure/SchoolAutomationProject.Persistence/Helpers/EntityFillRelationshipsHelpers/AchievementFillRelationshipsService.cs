using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.ViewModels.AchievementViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Persistence.Helpers.EntityFillRelationshipsHelpers
{
    public class AchievementFillRelationshipsService : IAchievementFillRelationshipsService
    {
        public AchievementFillRelationshipsService()
        {

        }

        public Task FillAchievementRelationships(Achievement achievement, WriteAchievementViewModel modelVM, string requestType)
        {
            throw new NotImplementedException();
        }
    }
}
