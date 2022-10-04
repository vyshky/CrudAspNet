using CrudAspNet.Dtos;
using CrudAspNet.Models;

namespace CrudAspNet.Repositories
{
    public class ProductRepository : IProductRepository
    {
        IEnumerable<ProductViewModel> repository;
        public ProductModel FindAll()
        {
            throw new NotImplementedException();
        }

        public ProductModel FindProductById(int n)
        {
            throw new NotImplementedException();
        }

        public ProductModel FindProductsByName(int n)
        {
            throw new NotImplementedException();
        }

        public ProductModel FindProductsToLimit(int n)
        {
            throw new NotImplementedException();
        }
    }
}
