using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.SQL
{
    public class ProductRepository : IProductRepository
    {
        private readonly MarketContext context;

        public ProductRepository(MarketContext context)
        {
            this.context = context;
        }

        public void AddProduct(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
        }

        public void DeleteProduct(int productId)
        {
            var product = context.Products.Find(productId);
            if (product != null) 
            { 
                context.Products.Remove(product);
                context.SaveChanges();
            }
        }

        public Product GetProductById(int productId)
        {
            return context.Products.Find(productId);
        }

        public IEnumerable<Product> GetProducts()
        {
            return context.Products.ToList();
        }

        public IEnumerable<Product> GetProductsByCategoryId(int categoryId)
        {
            return context.Products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void UpdateProduct(Product product)
        {
            var productToUpdate = context.Products.Find(product.Id);
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.Name = product.Name;
            productToUpdate.Price= product.Price;
            productToUpdate.Quantity= product.Quantity;

            context.SaveChanges();
        }
    }
}
