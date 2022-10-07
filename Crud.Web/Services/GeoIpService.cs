using Crud.Web.Models;
using System.Text.Json;

namespace Crud.Web.Services
{
    public class GeoIpService : IGeoIpService
    {        
        private readonly HttpClient httpClient;        
        public GeoIpService(IHttpClientFactory httpClientFactory)
        {
            httpClient = httpClientFactory.CreateClient();
        }

        public async Task<string> GetIp()
        {
            string url = "https://get.geojs.io/v1/ip";
            var respons = await httpClient.GetAsync(url);
            var ip = await respons.Content.ReadAsStringAsync();
            return ip.TrimEnd('\n');
        }

        public async Task<GeoViewModel> GetGeo()
        {
            var ip = await GetIp();
            GeoViewModel result;
            string url = $"https://get.geojs.io/v1/ip/geo/{ip}.json";
            var respons = await httpClient.GetAsync(url);
            var content = await respons.Content.ReadAsStringAsync();
            result = JsonSerializer.Deserialize<GeoViewModel>(content);
            return result;
        }
    }
}
