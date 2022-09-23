using CrudAspNet.Dtos;
using CrudAspNet.Models;

namespace CrudAspNet.Mappers
{
    public sealed class ProductMapper : IProductMapper
    {
        public ProductDto Map(ProductModel productModel) =>
            new()
            {
                Id = productModel.Id,
                Name = productModel.Name
            };
    }
}
