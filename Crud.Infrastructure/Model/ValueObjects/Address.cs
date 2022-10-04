using Crud.Infrastructure.SyperType;
using Microsoft.EntityFrameworkCore;

namespace Crud.Infrastructure.Model.ValueObjects
{
    [Owned]
    public sealed class Address : ValueObject<Address>
    {
        public int ZipCode;
        public string City;
    }
}
