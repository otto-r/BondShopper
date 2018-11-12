using BondShopper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BondShopper.ClientApp
{
    class Program
    {
        const string binding = "NetTcpBinding_IBondService";
        static void Main(string[] args)
        {
            var input = "";

            while (input != "q")
            {
                Console.WriteLine("What do you want to do?");

                Console.WriteLine("1. Get bonds");
                Console.WriteLine("2. Add bond");
                Console.WriteLine("3. Remove bond");
                Console.WriteLine("4. Update bond");

                input = Console.ReadLine();
                if (input == "1")
                {
                    ListBonds();
                }
                else if (input == "2")
                {
                    AddBondMenu();
                }
                else if (input == "3")
                {

                }
                else if (input == "4")
                {
                    Console.Clear();
                    ListBonds();
                    Console.Write("What bond?(id)");
                    var id = Console.ReadLine();
                    Console.Write("Change name: ");
                    var name = Console.ReadLine();
                    Bond bond = new Bond { Id = int.Parse(id), Name = name };
                    Proxy proxy = new Proxy(binding);
                    proxy.UpdateBond(bond);
                    proxy.Close();
                }

                input = Console.ReadLine();
            }
        }

        private static void AddBondMenu()
        {
            Console.WriteLine("Add Bond:");
            Console.Write("Name: ");
            var name = Console.ReadLine();
            Console.Write("Maturity: ");
            var maturity = Console.ReadLine();

            var bond = new Bond { Name = name, MaturityInMonths = int.Parse(maturity) };

            AddBond(bond);
        }

        private static void ListBonds()
        {
            var bonds = GetBonds();
            foreach (var bond in bonds)
            {
                Console.WriteLine($"{bond.Id}. {bond.Name}");
            }
            Console.ReadKey();
            Console.Clear();
        }

        private static List<Bond> GetBonds()
        {
            Proxy proxy = new Proxy(binding);
            var bonds = proxy.GetBonds();
            proxy.Close();
            return bonds;
        }

        private static void AddBond(Bond bond)
        {
            Proxy proxy = new Proxy(binding);
            proxy.AddBond(bond);
            proxy.Close();
        }
    }
}
