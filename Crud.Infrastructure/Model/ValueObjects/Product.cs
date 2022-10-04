using Crud.Infrastructure.SyperType;
using Microsoft.EntityFrameworkCore;

namespace Crud.Infrastructure.Model.ValueObjects
{
    public sealed class Product : ValueObject<Address>
    {
        public string Name { get; set; }
    }
}
