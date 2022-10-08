using Crud.Application.ViewModel;
using Crud.Domain.Services.Authentication;

namespace Crud.Application.Services.Login
{
    public class AutorizationService : IAutorizationService
    {
        private IAuthenticationActionsService authenticationActionsService;
        public AdminPanelViewModel User { get; set; }
        public AutorizationService()
        {
            authenticationActionsService = new AuthenticationActionsService();
            User = new AdminPanelViewModel();
        }

        public AdminPanelViewModel AutorizationUser(string login, string password)
        {
            var isLoggedIn = authenticationActionsService.AutorizationUser(login, password);
            User = new AdminPanelViewModel()
            {
                IsLoggedIn = isLoggedIn,
                Login = login,
                Password = password
            };
            return User;
        }
    }
}
