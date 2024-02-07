using SchoolAutomationProject.Application.Repositories.CommonRepositories;
using SchoolAutomationProject.Application.Repositories.SubCourseRepositories;
using SchoolAutomationProject.Domain.Entities.UniqueTables;
using SchoolAutomationProject.Persistence.Contexts;
using SchoolAutomationProject.Persistence.Repositories.CommonRepositories;

namespace SchoolAutomationProject.Persistence.Repositories.SubCourseRepositories
{
    public class SubCourseWriteRepository : WriteRepository<SubCourse>, ISubCourseWriteRepository
    {
        public SubCourseWriteRepository(SchoolAutomationProjectDbContext context) : base(context)
        {
        }
    }
}
