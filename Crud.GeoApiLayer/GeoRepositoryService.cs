using Crud.Web.Models;
using System.Text.Json;

namespace Crud.GeoApiLayer
{
    public class GeoRepositoryService
    {
        private readonly HttpClient httpClient;
        public GeoRepositoryService(IHttpClientFactory httpClientFactory)
        {
            httpClient = httpClientFactory.CreateClient();
        }
        public async Task<string> GetIpAsync()
        {
            string url = "https://get.geojs.io/v1/ip";
            var respons = await httpClient.GetAsync(url);
            var ip = await respons.Content.ReadAsStringAsync();
            return ip.TrimEnd('\n');
        }
        public async Task<GeoDto> GetGeoAsync(string ip)
        {
            GeoDto result;
            string url = $"https://get.geojs.io/v1/ip/geo/{ip}.json";
            var respons = await httpClient.GetAsync(url);
            var content = await respons.Content.ReadAsStringAsync();
            result = JsonSerializer.Deserialize<GeoDto>(content);
            return result;
        }
    }
}
