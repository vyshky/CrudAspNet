using Crud.Application.Services.Login;
using Crud.Application.ViewModel;
using Crud.Web.Models;
using Crud.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace Crud.Web.Controllers
{
    public class GeoLocationController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        IGeoIpService service;
        IAutorizationService service2;
        public GeoLocationController(ILogger<HomeController> logger, IGeoIpService service, IAutorizationService service2)
        {
            _logger = logger;
            this.service = service;
            this.service2 = service2;
        }
        public async Task<IActionResult> GeoInfo(AdminPanelViewModel model)
        {
            GeoViewModel geoView = new GeoViewModel();
            var user = service2.AutorizationUser(model.Login, model.Password);
            if (user.IsLoggedIn)
            {
                geoView = await service.GetGeo();
            }
            return View(geoView);
        }
    }
}
