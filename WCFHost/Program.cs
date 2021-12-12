using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCFHost
{
    class Program
    {
        static void Main(string[] args)
        {
           
            using (ServiceHost host = new ServiceHost(typeof(WCFService.Service1)))
            {
                host.Open();
                Console.WriteLine("Host has been Started!!!!");
                Console.ReadLine();
            }
        }
    }
}
