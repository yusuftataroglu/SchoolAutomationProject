using Microsoft.Extensions.Configuration;

namespace SchoolAutomationProject.Persistence.Helpers
{
    static class ConnectionStringHelper
    {
        internal static string GetConnectionString()
        {
            //Web App'e ulaşmak için Microsoft.Extensions.Configuration kütüphanesini ekledim.
            ConfigurationManager configurationManager = new();
            configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/SchoolAutomationProject.WebApp"));
            configurationManager.AddJsonFile("appsettings.json");
            string connectionString = configurationManager.GetConnectionString("DefaultConnection");
            return connectionString;
        }
    }
}