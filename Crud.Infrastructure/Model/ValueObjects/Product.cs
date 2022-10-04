using Crud.Infrastructure.SyperType;
using Microsoft.EntityFrameworkCore;

namespace Crud.Infrastructure.Model.ValueObjects
{
    [Owned]
    public sealed class Product : ValueObject<Product>
    {
        public string Name { get; set; }
    }
}
