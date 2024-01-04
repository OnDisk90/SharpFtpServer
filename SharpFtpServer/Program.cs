using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace SharpFtpServer
{
    class Program
    {
        static void Main(string[] args)
        {
            UseDNS();
            Console.WriteLine("User name exsist in user.xml");

            Console.WriteLine("Start FTP Server");

            //using (FtpServer server = new FtpServer(IPAddress.IPv6Any, 21))
            using (FtpServer server = new FtpServer(IPAddress.Any, 21))
            {
                server.Start();

                Console.WriteLine("Press any key to stop...");
                Console.ReadKey(true);
            }
        }
        static void UseDNS()
        {
            string hostName = Dns.GetHostName();
            Console.WriteLine("Host Name = " + hostName);
            IPHostEntry local = Dns.GetHostByName(hostName);
            foreach (IPAddress ipaddress in local.AddressList)
            {
                Console.WriteLine("IPAddress = " + ipaddress.ToString());
            }
        }
    }

}
