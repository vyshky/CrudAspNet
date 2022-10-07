using Crud.Web.Models;

namespace Crud.Web.Services
{
    public interface IGeoIpService
    {
        public Task<string> GetIp();
        public Task<GeoViewModel> GetGeo();
    }
}
