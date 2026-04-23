using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PCEClient.Models;

namespace PCEClient.Services
{
    public sealed class ApiService
    {
        private static readonly Lazy<ApiService> _instance = new Lazy<ApiService>(() => new ApiService());
        public static ApiService Instance => _instance.Value;

        private readonly HttpClient _httpClient;
        private const string BaseUrl        = "http://localhost:8080/components/passive";
        private const string ManufacturerUrl = "http://localhost:8080/manufacturers";

        private ApiService()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

        // ── Passive Components ────────────────────────────────────────────────

        public async Task<PassiveComponent> CreateAsync(PassiveComponentRequest request)
        {
            var response = await _httpClient.PostAsync(BaseUrl, ToJson(request));
            response.EnsureSuccessStatusCode();
            return JsonConvert.DeserializeObject<PassiveComponent>(await response.Content.ReadAsStringAsync());
        }

        public async Task<List<PassiveComponent>> GetAllAsync()
        {
            var response = await _httpClient.GetAsync(BaseUrl);
            response.EnsureSuccessStatusCode();
            return JsonConvert.DeserializeObject<List<PassiveComponent>>(await response.Content.ReadAsStringAsync());
        }

        public async Task<PassiveComponent> GetByIdAsync(int id)
        {
            var response = await _httpClient.GetAsync($"{BaseUrl}/{id}");
            if (response.StatusCode == System.Net.HttpStatusCode.NotFound) return null;
            response.EnsureSuccessStatusCode();
            return JsonConvert.DeserializeObject<PassiveComponent>(await response.Content.ReadAsStringAsync());
        }

        public async Task<List<PassiveComponent>> GetByPackageTypeAsync(PackageType packageType)
        {
            var response = await _httpClient.GetAsync($"{BaseUrl}?packageType={packageType}");
            response.EnsureSuccessStatusCode();
            return JsonConvert.DeserializeObject<List<PassiveComponent>>(await response.Content.ReadAsStringAsync());
        }

        public async Task<List<PassiveComponent>> GetByVoltageRangeAsync(double minVoltage, double maxVoltage)
        {
            var response = await _httpClient.GetAsync($"{BaseUrl}?minVoltage={minVoltage}&maxVoltage={maxVoltage}");
            response.EnsureSuccessStatusCode();
            return JsonConvert.DeserializeObject<List<PassiveComponent>>(await response.Content.ReadAsStringAsync());
        }

        public async Task<PassiveComponent> UpdateAsync(int id, PassiveComponentRequest request)
        {
            var response = await _httpClient.PutAsync($"{BaseUrl}/{id}", ToJson(request));
            if (response.StatusCode == System.Net.HttpStatusCode.NotFound) return null;
            response.EnsureSuccessStatusCode();
            return JsonConvert.DeserializeObject<PassiveComponent>(await response.Content.ReadAsStringAsync());
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"{BaseUrl}/{id}");
            if (response.StatusCode == System.Net.HttpStatusCode.NotFound) return false;
            response.EnsureSuccessStatusCode();
            return true;
        }

        // ── Manufacturers ─────────────────────────────────────────────────────

        public async Task<Manufacturer> CreateManufacturerAsync(ManufacturerRequest request)
        {
            var response = await _httpClient.PostAsync(ManufacturerUrl, ToJson(request));
            response.EnsureSuccessStatusCode();
            return JsonConvert.DeserializeObject<Manufacturer>(await response.Content.ReadAsStringAsync());
        }

        public async Task<List<Manufacturer>> GetAllManufacturersAsync(string country = null)
        {
            var url = string.IsNullOrWhiteSpace(country)
                ? ManufacturerUrl
                : $"{ManufacturerUrl}?country={Uri.EscapeDataString(country)}";
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            return JsonConvert.DeserializeObject<List<Manufacturer>>(await response.Content.ReadAsStringAsync());
        }

        public async Task<Manufacturer> GetManufacturerByIdAsync(int id)
        {
            var response = await _httpClient.GetAsync($"{ManufacturerUrl}/{id}");
            if (response.StatusCode == System.Net.HttpStatusCode.NotFound) return null;
            response.EnsureSuccessStatusCode();
            return JsonConvert.DeserializeObject<Manufacturer>(await response.Content.ReadAsStringAsync());
        }

        public async Task<Manufacturer> UpdateManufacturerAsync(int id, ManufacturerRequest request)
        {
            var response = await _httpClient.PutAsync($"{ManufacturerUrl}/{id}", ToJson(request));
            if (response.StatusCode == System.Net.HttpStatusCode.NotFound) return null;
            response.EnsureSuccessStatusCode();
            return JsonConvert.DeserializeObject<Manufacturer>(await response.Content.ReadAsStringAsync());
        }

        public async Task<bool> DeleteManufacturerAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"{ManufacturerUrl}/{id}");
            if (response.StatusCode == System.Net.HttpStatusCode.NotFound) return false;
            response.EnsureSuccessStatusCode();
            return true;
        }

        // ── Helper ────────────────────────────────────────────────────────────

        private static StringContent ToJson(object obj) =>
            new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json");
    }
}
