using SchoolAutomationProject.Application.Repositories.SubCourseRepositories;
using SchoolAutomationProject.Domain.Entities.UniqueTables;
using SchoolAutomationProject.Persistence.Contexts;
using SchoolAutomationProject.Persistence.Repositories.CommonRepositories;

namespace SchoolAutomationProject.Persistence.Repositories.SubCourseRepositories
{
    public class SubCourseReadRepository : ReadRepository<SubCourse>, ISubCourseReadRepository
    {
        public SubCourseReadRepository(SchoolAutomationProjectDbContext context) : base(context)
        {
        }
    }
}
