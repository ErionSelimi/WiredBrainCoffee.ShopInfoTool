using System;
using System.Diagnostics;
using WiredBrainCoffee.DataAccess;

namespace WiredBrainCoffee.ShopInfoTool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wired Brain Coffee - Shop Info Tool!");

            Console.WriteLine("Write 'help' to list available Coffee Shop commands, " + 
                "write 'quit' to exit the application.");

            var coffeeShopDataProvider = new CoffeeShopDataProvider();

            while (true)
            {
                var line = Console.ReadLine();

                if(string.Equals("quit",line,StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                var coffeeShops = coffeeShopDataProvider.LoadCoffeeShops();
                //Debugger.Break();
                if (string.Equals("help",line,StringComparison.OrdinalIgnoreCase))
                {
                    foreach(var coffeeShop in coffeeShops)
                    {
                        Console.WriteLine($"> {coffeeShop.Location}");
                    }
                }
            }

        }
    }
}

