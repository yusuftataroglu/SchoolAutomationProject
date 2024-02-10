using SchoolAutomationProject.Application.Repositories.CommonRepositories;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Application.Repositories.AttendanceRepositories
{
    public interface IAttendanceReadRepository:IReadRepository<Attendance>
    {
        public int GetAttendanceCountForStudent(Guid studentId);
    }
}
