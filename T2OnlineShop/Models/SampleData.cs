using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace T2OnlineShop.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<OnlineStoreEntities>
    {
        protected override void Seed(OnlineStoreEntities context)
        {
            var products = new List<Product>
            {
                new Product { name = "coffee Jacobs", price = 5.89M, type = "coffee" },
                new Product { name = "coffee Nescafe", price = 3.89M, type = "coffee" },
                new Product { name = "coffee Amaroy", price = 4.89M, type = "coffee" },
                new Product { name = "bread", price = 1.29M, type = "bread" },
                new Product { name = "shoes", price = 25.99M, type = "cloting" },
                new Product { name = "shirt", price = 15.99M, type = "cloting" },
                new Product { name = "Bucovina water", price = 0.89M, type = "water" },
                new Product { name = "Dorna water", price = 1.89M, type = "water" },
                new Product { name = "Aquatica water", price = 0.59M, type = "water" },
                new Product { name = "Albalact milk", price = 1.99M, type = "milk" },
                new Product { name = "Pilos milk", price = 1.49M, type = "milk" },
            };

            products.ForEach(p => context.Products.Add(p));
        }
    }
}