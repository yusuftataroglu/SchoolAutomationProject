using SchoolAutomationProject.Application.Repositories.AttendanceRepositories;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using SchoolAutomationProject.Persistence.Contexts;
using SchoolAutomationProject.Persistence.Repositories.CommonRepositories;

namespace SchoolAutomationProject.Persistence.Repositories.AttendanceRepositories
{
    public class AttendanceWriteRepository : WriteRepository<Attendance>, IAttendanceWriteRepository
    {
        public AttendanceWriteRepository(SchoolAutomationProjectDbContext context) : base(context)
        {
        }
    }
}
