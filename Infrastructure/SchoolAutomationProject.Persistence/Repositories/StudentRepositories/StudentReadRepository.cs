﻿using SchoolAutomationProject.Application.Repositories.StudentRepositories;
using SchoolAutomationProject.Domain.Entities.UniqueTables;
using SchoolAutomationProject.Persistence.Contexts;
using SchoolAutomationProject.Persistence.Repositories.CommonRepositories;

namespace SchoolAutomationProject.Persistence.Repositories.StudentRepositories
{
    public class AchievementReadRepository : ReadRepository<Student>, IStudentReadRepository
    {
        public AchievementReadRepository(SchoolAutomationProjectDbContext context) : base(context)
        {
        }
    }
}