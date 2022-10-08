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
        public ActionResult Index()
        {
            return View(service.User);
        }

        [HttpPost]
        public ActionResult AdminPanel(string login, string password)
        {
            return View(service.AutorizationUser(login, password));
        }
    }
}
