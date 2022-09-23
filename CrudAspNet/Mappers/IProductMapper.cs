using CrudAspNet.Dtos;
using CrudAspNet.Models;

namespace CrudAspNet.Mappers
{
    public interface IProductMapper
    {
        ProductDto Map(ProductModel productModel);
    }
}
