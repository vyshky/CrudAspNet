using CrudAspNet.Models;

namespace CrudAspNet.Repositories
{
    public interface IProductRepository
    {
        public ProductModel FindAll();
        public ProductModel FindProductById(int n);
        public ProductModel FindProductsToLimit(int n);
        public ProductModel FindProductsByName(int n);
    }
}
