using Crud.Domain.Entities;
using Crud.Infrastructure.Repositories;
using Crud.Infrastructure.Repositories.Implementation;

namespace Crud.Domain.Services.Authentication
{
    public class AuthenticationActionsService : IAuthenticationActionsService
    {
        private readonly IAuthenticationRepository repository;
        public bool IsLoggedIn { get; set; }
        private User _user;
        public AuthenticationActionsService()
        {           
            this.repository = new AuthenticationRepository();
            _user = new User();
        }
        public bool AutorizationUser(string login, string password)
        {
            if (!IsLoggedIn)
            {
                _user.Login = login;
                _user.Password = password;
                IsLoggedIn = repository.AutorizationUser(login, password);
                return IsLoggedIn;
            }
            return false;
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