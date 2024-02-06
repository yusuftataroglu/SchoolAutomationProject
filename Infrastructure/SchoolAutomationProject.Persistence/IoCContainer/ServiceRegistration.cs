﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SchoolAutomationProject.Application.Repositories.CommonRepositories;
using SchoolAutomationProject.Application.Repositories.StudentRepositories;
using SchoolAutomationProject.Persistence.Contexts;
using SchoolAutomationProject.Persistence.Repositories.StudentRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAutomationProject.Persistence.IoCContainer
{
    public static class ServiceRegistration
    {
        public static void AddService(this IServiceCollection services)
        {
            services.AddDbContext<SchoolAutomationProjectDbContext>(x => x.UseSqlServer("server=YUSUF-PC\\SQLEXPRESS;database=SchoolTest;Trusted_Connection=True;TrustServerCertificate=True;"));
            services.AddScoped<IStudentReadRepository, StudentReadRepository>();
            services.AddScoped<IStudentWriteRepository, StudentWriteRepository>();
        }
    }
}
