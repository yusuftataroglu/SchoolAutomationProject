using SchoolAutomationProject.Application.Repositories.TeacherRepositories;
using SchoolAutomationProject.Domain.Entities.UniqueTables;
using SchoolAutomationProject.Persistence.Contexts;
using SchoolAutomationProject.Persistence.Repositories.CommonRepositories;

namespace SchoolAutomationProject.Persistence.Repositories.TeacherRepositories
{
    public class TeacherWriteRepository : WriteRepository<Teacher>, ITeacherWriteRepository
    {
        public TeacherWriteRepository(SchoolAutomationProjectDbContext context) : base(context)
        {
        }
    }
}
