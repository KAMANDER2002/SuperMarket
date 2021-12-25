using CoreBuisness;
using System.Collections.Generic;

namespace UseCases
{
   public interface IViewCategoriesUseCase
    {
        IEnumerable<Category> Execute();
    }
}