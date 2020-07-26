using System.Collections.Generic;
using WiredBrainCoffee.DataAccess.Model;

namespace WiredBrainCoffee.DataAccess
{
    public class CoffeeShopDataProvider
    {
        //public IEnumerable<CoffeeShop> LoadCoffeeShops()
        //{
        //yield return new CoffeeShop { Location = "FrankFurt", BeansInStockInKg = 107 };
        //yield return new CoffeeShop { Location = "Freiburg", BeansInStockInKg = 23 };
        //yield return new CoffeeShop { Location = "Munich", BeansInStockInKg = 56 };
        //}

        public List<CoffeeShop> ListCoffeeShop { get; set; }
        public IEnumerable<CoffeeShop> LoadCoffeeShops()
        {
            ListCoffeeShop = new List<CoffeeShop>();

            CoffeeShop CoffeeShopFrankFurt = new CoffeeShop
            {
                Location = "FrankFurt",
                BeansInStockInKg = 107,
                PaperCupsInStock = 350
            };
            CoffeeShop CoffeeShopFreiburg = new CoffeeShop
            {
                Location = "Freiburg",
                BeansInStockInKg = 23,
                PaperCupsInStock = 120
            };
            CoffeeShop CoffeeShopMunich1 = new CoffeeShop
            {
                Location = "Munich1",
                BeansInStockInKg = 156,
                PaperCupsInStock = 100
            };
            CoffeeShop CoffeeShopMunich2 = new CoffeeShop
            {
                Location = "Munich2",
                BeansInStockInKg = 256,
                PaperCupsInStock = 200
            };

            ListCoffeeShop.Add(CoffeeShopFrankFurt);
            ListCoffeeShop.Add(CoffeeShopFreiburg);
            ListCoffeeShop.Add(CoffeeShopMunich1);
            ListCoffeeShop.Add(CoffeeShopMunich2);
            return ListCoffeeShop;
        }
    }
}
