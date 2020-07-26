using System;
using System.Diagnostics;
using System.Linq;
using WiredBrainCoffee.DataAccess;
using WiredBrainCoffee.DataAccess.Model;

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
                if (string.Equals("help", line, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Available coffee shop commands");
                    foreach (var coffeeShop in coffeeShops)
                    {
                        Console.WriteLine($"> {coffeeShop.Location}");
                    }
                }
                else 
                {

                    var foundCoffeeeShops = coffeeShops
                        .Where(x => x.Location.StartsWith(line, StringComparison.OrdinalIgnoreCase))
                        .ToList(); 
                    
                    if (foundCoffeeeShops.Count() == 0)
                    {
                        Console.WriteLine($"> Command '{line}' not found");
                    }
                    else if (foundCoffeeeShops.Count() == 1)
                    {
                        var coffeeShop = foundCoffeeeShops.Single();
                        Console.WriteLine($"> Location: {coffeeShop.Location }");
                        Console.WriteLine($"> Beans in stock: {coffeeShop.BeansInStockInKg} in kg");  
                    }
                    else
                    {
                        Console.WriteLine($"> Multiple matching coffe shops found. Please select one location:");
                        foreach(var coffeeType in foundCoffeeeShops)
                        {
                            Console.WriteLine($"> {coffeeType.Location}");
                        }
                    }

                }
            }

        }
    }
}

