using System;
using System.Collections.Generic;
using System.Linq;
using WiredBrainCoffee.DataAccess.Model;

namespace WiredBrainCoffee.ShopInfoTool
{
    public class CoffeeShopCommandHandler : ICommandHandler
    {
        private IEnumerable<CoffeeShop> coffeeShops;
        private string line;

        public CoffeeShopCommandHandler(IEnumerable<CoffeeShop> coffeeShops, string line)
        {
            this.coffeeShops = coffeeShops;
            this.line = line;
        }

        public void HandleCommand()
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
                foreach (var coffeeType in foundCoffeeeShops)
                {
                    Console.WriteLine($"> {coffeeType.Location}");
                }
            }
        }
    }
}