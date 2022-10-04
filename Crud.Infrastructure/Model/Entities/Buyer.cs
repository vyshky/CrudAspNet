using Crud.Infrastructure.Model.ValueObjects;
using Crud.Infrastructure.SyperType;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crud.Infrastructure.Model.Entities
{
    public sealed class Buyer : Entity
    {
        public long Id { get; set; }

        [NotMapped]
        public Basket Basket { get; set; }
        [NotMapped]
        public Address Address { get; set; }

        public Buyer()
        {
            Id = new Random().Next();
        }
    }
}
