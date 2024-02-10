using SchoolAutomationProject.Application.Repositories.TeacherRepositories;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using SchoolAutomationProject.Persistence.Contexts;
using SchoolAutomationProject.Persistence.Repositories.CommonRepositories;

namespace SchoolAutomationProject.Persistence.Repositories.TeacherRepositories
{
    public class TeacherReadRepository : ReadRepository<Teacher>, ITeacherReadRepository
    {
        public TeacherReadRepository(SchoolAutomationProjectDbContext context) : base(context)
        {
        }
    }
}
