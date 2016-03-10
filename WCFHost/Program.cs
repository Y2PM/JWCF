using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCFDemo;

namespace WCFHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(BookService)))
            {
                string address = "http://" + Dns.GetHostName() + ":8081/BookService";//FDM free from firewalls port.
                host.AddServiceEndpoint(typeof(IBookService), new BasicHttpBinding(), address);//Can be done in app . config too.

                host.Open();

                Console.WriteLine("Press the any key to stop.");
                Console.ReadLine();
            }
        }
    }
}
