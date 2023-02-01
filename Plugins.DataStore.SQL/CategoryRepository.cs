using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.SQL
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly MarketContext context;

        public CategoryRepository(MarketContext context)
        {
            this.context = context;
        }

        public void AddCategory(Category category)
        {
            context.Categories.Add(category);
            context.SaveChanges();
        }

        public void DeleteCategory(int categoryId)
        {
            var category = context.Categories.Find(categoryId);
            if (category != null)
            {
                context.Categories.Remove(category);
                context.SaveChanges();
            }
        }

        public IEnumerable<Category> GetCategories()
        {
           return context.Categories.ToList();
        }

        public Category GetCategoryById(int categoryId)
        {
            return context.Categories.Find(categoryId);
        }

        public void UpdateCategory(Category category)
        {
            var categoryToUpdate = context.Categories.Find(category.Id);
            categoryToUpdate.Name = category.Name;
            categoryToUpdate.Description = category.Description;
            context.SaveChanges();
        }
    }
}
