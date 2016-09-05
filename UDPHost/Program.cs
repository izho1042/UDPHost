using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace UDPHost
{
    class Program
    {
        public static void Main(String[] args)
        {
            ServiceHost host = new ServiceHost(typeof(FaqService));
            host.Open();

            Console.WriteLine("Press enter to terminate host...");
            Console.ReadLine();
            host.Close();
        }
    }
}
