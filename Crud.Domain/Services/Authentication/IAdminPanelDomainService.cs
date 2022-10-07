namespace Crud.Domain.Services.Authentication
{
    public interface IAdminPanelDomainService
    {
        public void AutorizationUser(string login, string password);
        public void CreateUser(string login, string password);
        public void DeleteUser();
        public void UpdatePassword(string newPassword);
        public void Logout();
    }
}
