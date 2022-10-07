using Crud.Web.Models;
using Crud.Web.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Crud.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        IGeoIpService service;
        GeoViewModel geo;
        public HomeController(ILogger<HomeController> logger, IGeoIpService service)
        {
            _logger = logger;
            geo = new GeoViewModel();
            this.service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<IActionResult> GeoIp()
        {
            geo = await service.GetGeo();
            return View(geo);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}