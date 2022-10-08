using Crud.Infrastructure.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace Crud.Infrastructure.Persistence
{
    public sealed class OrmContext : DbContext  // POCO файл
    {
        public DbSet<UserDto> Users { get; set; }
        public OrmContext() => Database.EnsureCreated();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // "Server=127.0.0.1;Port=5432;Database=myDataBase;User Id=myUsername;Password=myPassword"
            // "Host=localhost;Port=5433;Database=CrudLayers;Username=postgres;Password=797673"
            optionsBuilder.UseNpgsql("Server=127.0.0.1;Port=5432;Database=CrudLayers;User Id=postgres;Password=797673");
        }
    }
}