using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAutomationProject.Persistence.Helpers
{
    internal static class IpAddressHelper
    {
        internal static string GetIpAddress()
        {
            string hostName = Dns.GetHostName();
            var ipAddressArr = Dns.GetHostAddresses(hostName);
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
