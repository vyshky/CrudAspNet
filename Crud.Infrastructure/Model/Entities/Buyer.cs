using Crud.Infrastructure.Model.ValueObjects;
using Crud.Infrastructure.SyperType;

namespace Crud.Infrastructure.Model.Entities
{
    public sealed class Buyer : Entity
    {
        public long Id { get; set; }
        public Basket Basket { get; set; }
        public Address Address { get; set; }
    }
}
