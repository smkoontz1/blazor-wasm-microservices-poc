using LincolnAPI.Sdk.V1.Responses;
using System.Net.Http.Json;

namespace LincolnAPI.Sdk
{
    public class LincolnApiClient
    {
        private HttpClient _httpClient = new HttpClient();

        public LincolnApiClient(string baseUrl, string jwt)
        {
            this._httpClient.BaseAddress = new Uri(baseUrl);
            this._httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {jwt}");
        }

        public async Task<LincolnForecastResponse> GetWeatherAsync()
        {
            var _response = await _httpClient.GetFromJsonAsync<LincolnForecastResponse>("/lincoln");

            return _response ?? new LincolnForecastResponse();
        }
    }
}