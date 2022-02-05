using OmahaAPI.Sdk.V1.Responses;
using System.Net.Http.Json;

namespace OmahaAPI.Sdk
{
    public class OmahaApiClient
    {
        private HttpClient _httpClient = new HttpClient();

        public OmahaApiClient(string baseUrl, string jwt)
        {
            this._httpClient.BaseAddress = new Uri(baseUrl);
            this._httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {jwt}");
        }

        public async Task<OmahaForecastResponse> GetWeatherAsync()
        {
            var _response = await _httpClient.GetFromJsonAsync<OmahaForecastResponse>("/omaha");

            return _response ?? new OmahaForecastResponse();
        }
    }
}
