using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SchoolAutomationProject.Application.Repositories.CommonRepositories;
using SchoolAutomationProject.Application.Repositories.StudentRepositories;
using SchoolAutomationProject.Persistence.Contexts;
using SchoolAutomationProject.Persistence.Repositories.StudentRepositories;

namespace SchoolAutomationProject.Persistence.IoCContainer
{
    public static class ServiceRegistration
    {
        public static void AddService(this IServiceCollection services)
        {
            //Web App'e ulaşmak için Microsoft.Extensions.Configuration kütüphanesini ekledim.
            ConfigurationManager configurationManager = new();
            configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/SchoolAutomationProject.WebApp"));
            configurationManager.AddJsonFile("appsettings.json");
            string connectionString = configurationManager.GetConnectionString("DefaultConnection");


            services.AddDbContext<SchoolAutomationProjectDbContext>(x => x.UseSqlServer(connectionString));
            services.AddScoped<IStudentReadRepository, AchievementReadRepository>();
            services.AddScoped<IStudentWriteRepository, AttendanceWriteRepository>();
        }
    }
}
