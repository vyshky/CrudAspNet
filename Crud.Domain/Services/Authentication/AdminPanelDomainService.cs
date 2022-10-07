using Crud.Domain.Entities;
using Crud.Infrastructure.Repositories;

namespace Crud.Domain.Services.Authentication
{
    public class AdminPanelDomainService : IAdminPanelDomainService
    {
        private readonly IAuthenticationRepository repository;
        public bool IsLoggedIn { get; set; }
        private User _user;
        public AdminPanelDomainService(IAuthenticationRepository repository)
        {
            this.repository = repository;
            _user = new User();
        }
        public void AutorizationUser(string login, string password)
        {
            if (!IsLoggedIn)
            {
                _user.Login = login;
                _user.Password = password;
                IsLoggedIn = repository.AutorizationUser(login, password);
                //TODO :: получить информацию из api web3Storage
            }
        }
        public void CreateUser(string login, string password)
        {
            if (!IsLoggedIn)
            {
                IsLoggedIn = !repository.CreateUser(login, password);
            }
        }
        public void DeleteUser()
        {
            if (IsLoggedIn)
            {
                IsLoggedIn = !repository.DeleteUser(_user.Login, _user.Password);
            }
        }
        public void UpdatePassword(string newPassword)
        {
            if (IsLoggedIn)
            {
                IsLoggedIn = !repository.UpdatePassword(_user.Login, _user.Password, newPassword);
            }
        }

        public void Logout()
        {
            IsLoggedIn = false;
        }
    }
}