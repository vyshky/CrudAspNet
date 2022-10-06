using Crud.Infrastructure.SyperType;

namespace Crud.Infrastructure.Model.Entities
{ 
    public class Authentication : Entity
    {
        public Guid Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
