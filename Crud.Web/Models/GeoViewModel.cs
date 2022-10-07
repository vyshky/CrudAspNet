using System.Text.Json.Serialization;

namespace Crud.Web.Models
{
    //public class GeoViewModel
    //{
    //    public string OrganizationName { get; set; }
    //    public string Region { get; set; }
    //    public int Accuracy { get; set; }
    //    public int Asn { get; set; }
    //    public string Organization { get; set; }
    //    public string Timezone { get; set; }
    //    public string Longitude { get; set; }
    //    public string CountryCode3 { get; set; }
    //    public string AreaCode { get; set; }
    //    public string Ip { get; set; }
    //    public string City { get; set; }
    //    public string Country { get; set; }
    //    public string ContinentCode { get; set; }
    //    public string CountryCode { get; set; }
    //    public string Latitude { get; set; }
    //}

    //[JsonPropertyName("Search")]
    public class GeoViewModel
    {
        [JsonPropertyName("organization_name")]
        public string OrganizationName { get; set; }
        [JsonPropertyName("region")]
        public string Region { get; set; }
        [JsonPropertyName("accuracy")]
        public int Accuracy { get; set; }
        [JsonPropertyName("asn")]
        public int Asn { get; set; }
        [JsonPropertyName("organization")]
        public string Organization { get; set; }
        [JsonPropertyName("timezone")]
        public string Timezone { get; set; }
        [JsonPropertyName("longitude")]
        public string Longitude { get; set; }
        [JsonPropertyName("country_code3")]
        public string CountryCode3 { get; set; }
        [JsonPropertyName("area_code")]
        public string AreaCode { get; set; }
        [JsonPropertyName("ip")]
        public string Ip { get; set; }
        [JsonPropertyName("city")]
        public string City { get; set; }
        [JsonPropertyName("country")]
        public string Country { get; set; }
        [JsonPropertyName("continent_code")]
        public string ContinentCode { get; set; }
        [JsonPropertyName("country_code")]
        public string CountryCode { get; set; }
        [JsonPropertyName("latitude")]
        public string Latitude { get; set; }
    }

}
