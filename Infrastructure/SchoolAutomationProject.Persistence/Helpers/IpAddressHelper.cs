using System.Net;

namespace SchoolAutomationProject.Persistence.Helpers
{
    internal static class IpAddressHelper
    {
        internal static async Task<string> GetIpAddress()
        {
            string hostName = Dns.GetHostName();
            var ipAddressArr = await Dns.GetHostAddressesAsync(hostName);
            foreach (var ipAddress in ipAddressArr)
            {
                if (ipAddress.AddressFamily==System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    return ipAddress.ToString();
                }
            }
            return "Bulunamadı!";
        }
    }
}
