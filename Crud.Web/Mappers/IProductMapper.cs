using CrudAspNet.Dtos;
using CrudAspNet.Models;

namespace CrudAspNet.Mappers
{
    public interface IProductMapper
    {
        ProductViewModel Map(ProductModel productModel);
    }
}
