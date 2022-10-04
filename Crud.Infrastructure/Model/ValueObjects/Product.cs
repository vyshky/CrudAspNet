using Crud.Infrastructure.SyperType;
using Microsoft.EntityFrameworkCore;

namespace Crud.Infrastructure.Model.ValueObjects
{
    //[Owned] // Этот атрибуд говорит что класс будет использоваться как valueObject и ему не нужен id
    public sealed class Product
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }
}
