namespace Crud.Domain.Services.Authentication
{
    public interface IAuthenticationActionsService
    {
        public bool AutorizationUser(string login, string password);
        public void CreateUser(string login, string password);
        public void DeleteUser();
        public void UpdatePassword(string newPassword);
        public void Logout();
    }
}
