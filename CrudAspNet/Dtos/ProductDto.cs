using CrudAspNet.Models;

namespace CrudAspNet.Dtos
{
    public class ProductDto
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public static ProductDto Map(ProductModel productModel) =>
            new()
            {
                Id = productModel.Id,
                Name = productModel.Name
            };

    }
}
