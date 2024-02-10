using SchoolAutomationProject.Application.Repositories.AttendanceRepositories;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using SchoolAutomationProject.Persistence.Contexts;
using SchoolAutomationProject.Persistence.Repositories.CommonRepositories;

namespace SchoolAutomationProject.Persistence.Repositories.AttendanceRepositories
{
    public class AttendanceReadRepository : ReadRepository<Attendance>, IAttendanceReadRepository
    {
        private readonly SchoolAutomationProjectDbContext _context;

        public AttendanceReadRepository(SchoolAutomationProjectDbContext context) : base(context)
        {
            _context = context;
        }

        public int GetAttendanceCountForStudent(Guid studentId)
        {
            int? attendanceCount = _context.Attendances.Count(a => a.StudentId == studentId && a.AttendanceStatus == Domain.Entities.Enums.AttendanceStatus.Yok);
            return attendanceCount ?? 0;
            
        }
    }
}
