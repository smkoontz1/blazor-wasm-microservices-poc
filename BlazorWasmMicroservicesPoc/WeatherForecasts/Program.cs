using LincolnAPI.Sdk;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using OmahaAPI.Sdk;
using WeatherForecasts;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var _lincolnApiBaseRoute = "https://localhost:7208";
var _omahaApiBaseRoute = "https://localhost:7202";

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped(sp => new LincolnApiClient(_lincolnApiBaseRoute, "need to figure out how auth works here"));
builder.Services.AddScoped(sp => new OmahaApiClient(_omahaApiBaseRoute, "need to figure out how auth works here"));

await builder.Build().RunAsync();
