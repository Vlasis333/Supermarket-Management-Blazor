using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class ProductInMemoryRepository : IProductRepository
    {
        public List<Product> products { get; set; }

        public ProductInMemoryRepository()
        {
            //Init with default values
            products = new List<Product>()
            {
                new Product{ Id = 1, CategoryId = 1, Name = "Iced Tea", Quantity = 100, Price = 1.99 },
                new Product{ Id = 2, CategoryId = 1, Name = "Canada Dry", Quantity = 200, Price = 1.99 },
                new Product{ Id = 3, CategoryId = 2, Name = "Whole Wheat Bread", Quantity = 300, Price = 1.50 },
                new Product{ Id = 4, CategoryId = 2, Name = "White Bread", Quantity = 400, Price = 2.50 },
                new Product{ Id = 5, CategoryId = 3, Name = "Wagyu A5", Quantity = 70, Price = 150 },
                new Product{ Id = 6, CategoryId = 3, Name = "Rib Eye", Quantity = 160, Price = 75.25 }
            };
        }
        public IEnumerable<Product> GetProducts()
        {
            return products;
        }
    }
}
