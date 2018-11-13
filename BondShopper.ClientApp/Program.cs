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
        static void Main(string[] args)
        {
            var input = "";

            while (input != "q")
            {
                Console.Clear();
                Console.WriteLine("What do you want to do?");

                Console.WriteLine("1. Get bonds");
                Console.WriteLine("2. Add bond");
                Console.WriteLine("3. Remove bond");
                Console.WriteLine("4. Update bond");
                Console.WriteLine("q. To Quit");

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
                    DeleteBond();
                }
                else if (input == "4")
                {
                    UpdateBond();
                }

                input = Console.ReadLine();
            }
        }

        private static void UpdateBond()
        {
            Console.Clear();
            ListBonds();
            Console.Write("What bond?(id)");
            var id = Console.ReadLine();
            Console.Write("Change name: ");
            var name = Console.ReadLine();
            Bond bond = new Bond { Id = int.Parse(id), Name = name };
            BondShopper1.BondServiceClient proxy = new BondShopper1.BondServiceClient();
            proxy.UpdateBond(bond);
            proxy.Close();
        }

        private static void DeleteBond()
        {
            var input = "";
            while (input != "q")
            {
                var bonds = GetBonds();
                ListBonds();
                Console.WriteLine("What bond do you want to delete?");
                input = Console.ReadLine();
                if (bonds.Where(b => b.Id == int.Parse(input)).Count() == 1)
                {
                    var bond = bonds.Single(b => b.Id == int.Parse(input));
                    BondShopper1.BondServiceClient proxy = new BondShopper1.BondServiceClient();
                    proxy.DeleteBond(bond);
                    proxy.Close();
                    input = "q";
                }
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
        }

        private static List<Bond> GetBonds()
        {
            BondShopper1.BondServiceClient proxy = new BondShopper1.BondServiceClient();
            var bonds = proxy.GetBonds();
            proxy.Close();
            return bonds;
        }

        private static void AddBond(Bond bond)
        {
            BondShopper1.BondServiceClient proxy = new BondShopper1.BondServiceClient();
            proxy.AddBond(bond);
            proxy.Close();
        }
    }
}
