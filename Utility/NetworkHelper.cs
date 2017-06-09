using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public class NetworkHelper
    {
        public static string GetLocalIP()
        {
            return GetIpByHostName(Dns.GetHostName());
        }

        private static string GetIpByHostName(string hostName)
        {
            hostName = hostName.Trim();
            if (hostName == string.Empty)
                return string.Empty;
            try
            {
                string IPAddress = string.Empty;
                System.Net.IPHostEntry host = System.Net.Dns.GetHostEntry(hostName);
                foreach (System.Net.IPAddress ip in host.AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        IPAddress = ip.ToString();
                        break;
                    }
                }
                return IPAddress;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
    }
}
