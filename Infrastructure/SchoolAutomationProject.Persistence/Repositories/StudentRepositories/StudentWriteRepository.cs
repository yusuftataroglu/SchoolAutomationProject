﻿using SchoolAutomationProject.Application.Repositories.CommonRepositories;
using SchoolAutomationProject.Domain.Entities.UniqueTables;
using SchoolAutomationProject.Persistence.Contexts;
using SchoolAutomationProject.Persistence.Repositories.CommonRepositories;

namespace SchoolAutomationProject.Persistence.Repositories.StudentRepositories
{
    public class AttendanceWriteRepository : WriteRepository<Student>, IStudentWriteRepository
    {
        public AttendanceWriteRepository(SchoolAutomationProjectDbContext context) : base(context)
        {
        }
    }
}