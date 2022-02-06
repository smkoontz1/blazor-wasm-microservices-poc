﻿using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

namespace WeatherForecasts.Client.AuthorizationHandlers
{
    public class LincolnAuthorizationMessageHandler : AuthorizationMessageHandler
    {
        public LincolnAuthorizationMessageHandler(IAccessTokenProvider provider,
            NavigationManager navigationManager)
            : base(provider, navigationManager)
        {
            ConfigureHandler(
                authorizedUrls: new[] { "https://localhost:7269" },
                scopes: new[] { "https://smkoontz1hotmail.onmicrosoft.com/17e04c6e-ff8f-4536-b7a8-f2a90638936b/Lincoln.Read" });
        }
    }
}
