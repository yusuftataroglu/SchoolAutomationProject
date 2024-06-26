﻿using SchoolAutomationProject.Application.Repositories.MainCourseRepositories;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using SchoolAutomationProject.Persistence.Contexts;
using SchoolAutomationProject.Persistence.Repositories.CommonRepositories;

namespace SchoolAutomationProject.Persistence.Repositories.MainCourseRepositories
{
    public class MainCourseReadRepository : ReadRepository<MainCourse>, IMainCourseReadRepository
    {
        public MainCourseReadRepository(SchoolAutomationProjectDbContext context) : base(context)
        {
        }
    }
}
