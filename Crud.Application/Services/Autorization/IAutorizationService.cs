using Crud.Application.ViewModel;

namespace Crud.Application.Services.Login
{
    public interface IAutorizationService
    {
        public AdminPanelViewModel User { get; set; }
        public AdminPanelViewModel AutorizationUser(string login, string password);
    }
}
