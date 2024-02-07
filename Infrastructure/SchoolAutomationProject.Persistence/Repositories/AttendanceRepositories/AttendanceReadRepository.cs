using SchoolAutomationProject.Application.Repositories.AttendanceRepositories;
using SchoolAutomationProject.Domain.Entities.UniqueTables;
using SchoolAutomationProject.Persistence.Contexts;
using SchoolAutomationProject.Persistence.Repositories.CommonRepositories;

namespace SchoolAutomationProject.Persistence.Repositories.AttendanceRepositories
{
    public class AttendanceReadRepository : ReadRepository<Attendance>, IAttendanceReadRepository
    {
        public AttendanceReadRepository(SchoolAutomationProjectDbContext context) : base(context)
        {
        }
    }
}
