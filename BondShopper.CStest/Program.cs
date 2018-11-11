using BondShopper.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace BondShopper.CStest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ServiceHost host = new ServiceHost(typeof(BondService));
                host.Open();
                Console.WriteLine("Hit the Any key to exit");
                Console.ReadKey();
                host.Close();

            }
            catch (Exception c)
            {
                Console.WriteLine("error: " + c);
            }
        }
    }
}
