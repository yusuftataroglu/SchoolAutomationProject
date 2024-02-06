using SchoolAutomationProject.Application.Repositories.CommonRepositories;
using SchoolAutomationProject.Domain.Entities.UniqueTables;
using SchoolAutomationProject.Persistence.Contexts;
using SchoolAutomationProject.Persistence.Repositories.CommonRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAutomationProject.Persistence.Repositories.StudentRepositories
{
    public class StudentWriteRepository : WriteRepository<Student>, IStudentWriteRepository
    {
        public StudentWriteRepository(SchoolAutomationProjectDbContext context) : base(context)
        {
        }
    }
}
