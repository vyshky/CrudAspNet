namespace Crud.Infrastructure.Repositories
{
    public interface IAuthenticationRepository : IRepository
    {
        public bool AutorizationUser(string login, string password);
        public bool CreateUser(string login, string password);
        public bool DeleteUser(string login, string password);
        public bool UpdatePassword(string login, string password, string newPassword);
    }
}
