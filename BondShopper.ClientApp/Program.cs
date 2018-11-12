using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BondShopper.ClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Proxy proxy = new Proxy("net.tcp://localhost2113/Bondservice");
            Proxy proxy = new Proxy("NetTcpBinding_IBondService");
            var bonds = proxy.GetBonds();
            proxy.Close();
            foreach (var bond in bonds)
            {
                Console.WriteLine(bond.Name);
            }
            Console.ReadKey();
        }
    }
}
