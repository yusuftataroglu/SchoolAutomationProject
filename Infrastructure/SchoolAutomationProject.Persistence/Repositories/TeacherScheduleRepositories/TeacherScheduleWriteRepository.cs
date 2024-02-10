using SchoolAutomationProject.Application.Repositories.TeacherScheduleRepositories;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using SchoolAutomationProject.Persistence.Contexts;
using SchoolAutomationProject.Persistence.Repositories.CommonRepositories;

namespace SchoolAutomationProject.Persistence.Repositories.TeacherScheduleRepositories
{
    public class TeacherScheduleWriteRepository : WriteRepository<TeacherSchedule>, ITeacherScheduleWriteRepository
    {
        public TeacherScheduleWriteRepository(SchoolAutomationProjectDbContext context) : base(context)
        {
        }
    }
}
