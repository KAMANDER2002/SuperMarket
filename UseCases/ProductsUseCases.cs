using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreBuisness;
using UseCases.DataStorePluginInterfaces;

namespace UseCases
{
   public class ProductsUseCases : IProductsUseCases
    {
        private readonly IProductRepository productRepository;

        public ProductsUseCases(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public IEnumerable<Product> Execute()
        {
            return productRepository.GetProducts();
        }

    }
}
