using Crud.Infrastructure.Model.Entities;
using Crud.Infrastructure.Model.ValueObjects;
using Microsoft.EntityFrameworkCore;

namespace Crud.Infrastructure.Persistence
{
    public sealed class OrmContext : DbContext  // POCO файл
    {
        public DbSet<Buyer> Buyer { get; set; }
        public DbSet<Basket> Basket { get; set; }

        public DbSet<Product> Product { get; set; }
        //public DbSet<Address> Address { get; set; }
        public OrmContext() => Database.EnsureCreated();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // "Server=127.0.0.1;Port=5432;Database=myDataBase;User Id=myUsername;Password=myPassword"
            // "Host=localhost;Port=5433;Database=CrudLayers;Username=postgres;Password=797673"
            optionsBuilder.UseNpgsql("Server=127.0.0.1;Port=5432;Database=CrudLayers;User Id=postgres;Password=797673");
        }
    }
}
