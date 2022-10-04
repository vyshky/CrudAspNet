using Crud.Infrastructure.Model.ValueObjects;
using Crud.Infrastructure.SyperType;

namespace Crud.Infrastructure.Model.Entities
{
    public sealed class Basket : Entity // ValueObject(Model)
    {
        public long Id { get; set; }        
        public List<long> ProductsId { get; set; }
    }
}
