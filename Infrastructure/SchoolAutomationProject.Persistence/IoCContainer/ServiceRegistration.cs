using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SchoolAutomationProject.Application.Repositories.CommonRepositories;
using SchoolAutomationProject.Application.Repositories.StudentRepositories;
using SchoolAutomationProject.Persistence.Contexts;
using SchoolAutomationProject.Persistence.Helpers;
using SchoolAutomationProject.Persistence.Repositories.StudentRepositories;

namespace SchoolAutomationProject.Persistence.IoCContainer
{
    public static class ServiceRegistration
    {
        public static void AddService(this IServiceCollection services)
        {
            services.AddDbContext<SchoolAutomationProjectDbContext>(x => x.UseSqlServer(ConnectionStringHelper.GetConnectionString()));
            services.AddScoped<IStudentReadRepository, AchievementReadRepository>();
            services.AddScoped<IStudentWriteRepository, AttendanceWriteRepository>();
        }
    }
}
