using Crud.Infrastructure.Model.ValueObjects;
using Crud.Infrastructure.SyperType;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crud.Infrastructure.Model.Entities
{
    public sealed class Basket : Entity // ValueObject(Model)
    {
        public long Id { get; set; }
        [NotMapped]
        public List<Product> Products { get; set; }
    }
}
