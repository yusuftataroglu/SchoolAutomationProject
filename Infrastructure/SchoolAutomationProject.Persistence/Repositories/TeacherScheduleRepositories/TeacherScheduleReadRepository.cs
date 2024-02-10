using SchoolAutomationProject.Application.Repositories.TeacherScheduleRepositories;
using SchoolAutomationProject.Domain.Entities.UniqueTables;
using SchoolAutomationProject.Persistence.Contexts;
using SchoolAutomationProject.Persistence.Repositories.CommonRepositories;

namespace SchoolAutomationProject.Persistence.Repositories.TeacherScheduleRepositories
{
    public class TeacherScheduleReadRepository : ReadRepository<TeacherSchedule>, ITeacherScheduleReadRepository
    {
        public TeacherScheduleReadRepository(SchoolAutomationProjectDbContext context) : base(context)
        {
        }
    }
}
