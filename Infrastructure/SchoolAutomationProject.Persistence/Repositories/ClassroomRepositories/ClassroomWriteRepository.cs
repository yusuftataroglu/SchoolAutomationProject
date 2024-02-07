using SchoolAutomationProject.Application.Repositories.ClassroomRepositories;
using SchoolAutomationProject.Application.Repositories.CommonRepositories;
using SchoolAutomationProject.Domain.Entities.UniqueTables;
using SchoolAutomationProject.Persistence.Contexts;
using SchoolAutomationProject.Persistence.Repositories.CommonRepositories;

namespace SchoolAutomationProject.Persistence.Repositories.ClassroomRepositories
{
    public class ClassroomWriteRepository : WriteRepository<Classroom>, IClassroomWriteRepository
    {
        public ClassroomWriteRepository(SchoolAutomationProjectDbContext context) : base(context)
        {
        }
    }
}
