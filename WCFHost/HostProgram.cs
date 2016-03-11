﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCFDemo;

namespace WCFHost
{
    class HostProgram
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(ChatService)))
            {
                string address = "http://" + Dns.GetHostName() + ":8081/ChatService";//FDM free from firewalls port.
                host.AddServiceEndpoint(typeof(IChatService), new BasicHttpBinding(), address);//Can be done in app . config too.

                host.Open();

                Console.WriteLine("Press enter to stop.");
                Console.ReadLine();
            }
        }
    }
}
