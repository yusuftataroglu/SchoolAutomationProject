using SchoolAutomationProject.Application.Repositories.StudentRepositories;
using SchoolAutomationProject.Domain.Entities.UniqueTables;
using SchoolAutomationProject.Persistence.Contexts;
using SchoolAutomationProject.Persistence.Repositories.CommonRepositories;

namespace SchoolAutomationProject.Persistence.Repositories.StudentRepositories
{
    public class StudentReadRepository : ReadRepository<Student>, IStudentReadRepository
    {
        public StudentReadRepository(SchoolAutomationProjectDbContext context) : base(context)
        {
        }
    }
}
