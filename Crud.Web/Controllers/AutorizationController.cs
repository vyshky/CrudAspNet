using Crud.Application.Services.Login;
using Microsoft.AspNetCore.Mvc;

namespace Crud.Web.Controllers
{
    public class AutorizationController : Controller
    {
        private readonly ILogger<HomeController> logger;

        IAutorizationService service;
        public AutorizationController(ILogger<HomeController> logger, IAutorizationService service)
        {
            this.logger = logger;
            this.service = service;
        }
        public IActionResult Index()
        {
            return View(service.User);
        }

        [HttpPost]
        public async Task<IActionResult> AdminPanel(string login, string password)
        {
            var user = service.AutorizationUser(login, password);
            return View(user);
        }
    }
}
