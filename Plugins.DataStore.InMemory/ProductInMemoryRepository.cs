using CoreBuisness;
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
        private List<Product> products;

        public ProductInMemoryRepository()
        {
            products = new List<Product> 
            {
                new Product{ProductId = 1, CategoryId = 1, Name = "Индийский чай", Quantity = 100, Price = 299.99},
                new Product{ProductId = 2, CategoryId = 1, Name = "Черный чай", Quantity = 100, Price = 299.99},
                new Product{ProductId = 3, CategoryId = 1, Name = "Крепкий кофе", Quantity = 100, Price = 299.99},
                new Product{ProductId = 4, CategoryId = 2, Name = "Мороженное Magnit", Quantity = 100, Price = 99.99},
                new Product{ProductId = 5, CategoryId = 3, Name = "Работник Вася", Quantity = 100, Price = 2999.99}
            };
        }
        public IEnumerable<Product> GetProducts()
        {
            return products;
        }
    }
}
