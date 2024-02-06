using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Protocols;
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
            //Web App'e ulaşmak için Microsoft.Extensions.Configuration kütüphanesini ekledik.
            ConfigurationManager configurationManager = new();
            configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/SchoolAutomationProject.WebApp"));
            configurationManager.AddJsonFile("appsettings.json");
            string connectionString = configurationManager.GetConnectionString("DefaultConnection");


            services.AddDbContext<SchoolAutomationProjectDbContext>(x => x.UseSqlServer(connectionString));
            services.AddScoped<IStudentReadRepository, StudentReadRepository>();
            services.AddScoped<IStudentWriteRepository, StudentWriteRepository>();
        }
    }
}
