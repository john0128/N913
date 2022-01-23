using System;
using System.IO;
using System.Net;

namespace NjOtter
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    var ipaddress = ip.ToString();
                    Console.WriteLine("IP Address = " + ip.ToString());
                }
            }
            Console.Write("login as: ");
            var username = Console.ReadLine();
            string ustr = username + "@";
            Console.WriteLine(ustr, "");
            Console.Title = "NjOtter CLI Enviornment";
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string folpath = doc + "/NjOtter Saves";
            DirectoryInfo di = new DirectoryInfo(folpath);
            if (di.Exists == false)
            {
                di.Create();
            }
            Main main = new Main();
            main.Start();
        }
    }
}
