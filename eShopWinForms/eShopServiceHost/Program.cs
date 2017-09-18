using eShopServiceLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace eShopServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(CatalogService)))
            {
                host.Open();

                Console.WriteLine("The service is listening at {0}", host.BaseAddresses[0]);
                while(true)
                {
                    Thread.Sleep(1000);
                }

                host.Close();
            }
        }
    }
}
