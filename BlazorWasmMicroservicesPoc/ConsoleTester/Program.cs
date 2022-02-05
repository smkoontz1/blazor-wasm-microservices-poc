using LincolnAPI.Sdk;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var _client = new LincolnApiClient("https://localhost:7208", "token");

var _response = await _client.GetWeatherAsync();

Console.WriteLine($"Location: {_response.Location}");
Console.WriteLine($"Weather Type: {_response.WeatherType}");
