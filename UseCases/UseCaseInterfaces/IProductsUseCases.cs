using CoreBuisness;

namespace UseCases
{
   public interface IProductsUseCases
    {
        System.Collections.Generic.IEnumerable<Product> Execute();
    }
}