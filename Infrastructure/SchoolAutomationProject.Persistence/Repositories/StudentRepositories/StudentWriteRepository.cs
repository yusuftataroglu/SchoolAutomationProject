using SchoolAutomationProject.Application.Repositories.CommonRepositories;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using SchoolAutomationProject.Persistence.Contexts;
using SchoolAutomationProject.Persistence.Repositories.CommonRepositories;

namespace SchoolAutomationProject.Persistence.Repositories.StudentRepositories
{
    public class StudentWriteRepository : WriteRepository<Student>, IStudentWriteRepository
    {
        public StudentWriteRepository(SchoolAutomationProjectDbContext context) : base(context)
        {
        }
    }
}
