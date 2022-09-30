using CrudAspNet.Models;

namespace Crud.Domain.Repositories
{
    public interface IProductRepository
    {
        public void Update(ProductModel productModel);
        public void Delete(ProductModel productModel);
        public void Insert(ProductModel productModel);
        public void Select(ProductModel productModel);
    }
}
