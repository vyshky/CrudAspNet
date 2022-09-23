using CrudAspNet.Dtos;
using CrudAspNet.Models;

namespace CrudAspNet.Mappers
{
    public class ProductMapper
    {
        public ProductDto Map(ProductModel productModel) =>
            new()
            {
                Id = productModel.Id,
                Name = productModel.Name
            };
    }
}
