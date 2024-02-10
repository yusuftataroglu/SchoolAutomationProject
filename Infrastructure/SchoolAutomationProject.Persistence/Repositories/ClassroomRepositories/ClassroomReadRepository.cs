using SchoolAutomationProject.Application.Repositories.ClassroomRepositories;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using SchoolAutomationProject.Persistence.Contexts;
using SchoolAutomationProject.Persistence.Repositories.CommonRepositories;

namespace SchoolAutomationProject.Persistence.Repositories.ClassroomRepositories
{
    public class ClassroomReadRepository : ReadRepository<Classroom>, IClassroomReadRepository
    {
        public ClassroomReadRepository(SchoolAutomationProjectDbContext context) : base(context)
        {
        }
    }
}
