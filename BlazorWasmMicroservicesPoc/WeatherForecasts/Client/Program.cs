using Lincoln.Shared;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Omaha.Shared;
using WeatherForecasts.Client;
using WeatherForecasts.Client.AuthorizationHandlers;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var _omahaBaseUrl = "https://localhost:7252";
var _lincolnBaseUrl = "https://localhost:7269";

builder.Services.AddScoped<OmahaAuthorizationMessageHandler>();
builder.Services.AddScoped<LincolnAuthorizationMessageHandler>();

builder.Services.AddHttpClient("Omaha.ServerAPI", client => client.BaseAddress = new Uri(_omahaBaseUrl))
    .AddHttpMessageHandler<OmahaAuthorizationMessageHandler>();
builder.Services.AddHttpClient("Lincoln.ServerAPI", client => client.BaseAddress = new Uri(_lincolnBaseUrl))
    .AddHttpMessageHandler<LincolnAuthorizationMessageHandler>();

// Supply HttpClient instances that include access tokens when making requests to the server project
builder.Services.AddScoped<OmahaHttpClient>((sp => new OmahaHttpClient(sp.GetRequiredService<IHttpClientFactory>().CreateClient("Omaha.ServerAPI"))));
builder.Services.AddScoped<LincolnHttpClient>(sp => new LincolnHttpClient(sp.GetRequiredService<IHttpClientFactory>().CreateClient("Lincoln.ServerAPI")));

builder.Services.AddMsalAuthentication(options =>
{
    builder.Configuration.Bind("AzureAd", options.ProviderOptions.Authentication);
    options.ProviderOptions.DefaultAccessTokenScopes.Add("https://smkoontz1hotmail.onmicrosoft.com/17e04c6e-ff8f-4536-b7a8-f2a90638936b/Omaha.Read");
    options.ProviderOptions.AdditionalScopesToConsent.Add("https://smkoontz1hotmail.onmicrosoft.com/17e04c6e-ff8f-4536-b7a8-f2a90638936b/Lincoln.Read");
    options.ProviderOptions.LoginMode = "redirect";
});

await builder.Build().RunAsync();
