using SchoolAutomationProject.Application.Repositories.CommonRepositories;
using SchoolAutomationProject.Application.Repositories.MainCourseRepositories;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using SchoolAutomationProject.Persistence.Contexts;
using SchoolAutomationProject.Persistence.Repositories.CommonRepositories;

namespace SchoolAutomationProject.Persistence.Repositories.MainCourseRepositories
{
    public class MainCourseWriteRepository : WriteRepository<MainCourse>, IMainCourseWriteRepository
    {
        public MainCourseWriteRepository(SchoolAutomationProjectDbContext context) : base(context)
        {
        }
    }
}
