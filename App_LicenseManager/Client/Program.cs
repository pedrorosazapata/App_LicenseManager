using App_LicenseManager.Client;
using App_LicenseManager.Client.Auth;
using Blazored.Modal;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddHttpClient("App_LicenseManager.ServerAPI", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress));
   // .AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();

// Supply HttpClient instances that include access tokens when making requests to the server project
builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("App_LicenseManager.ServerAPI"));

builder.Services.AddApiAuthorization();
//builder.Services.AddAuthorizationCore();
//builder.Services.AddScoped<JwtAuthenticatorProvider>();
//builder.Services.AddScoped<AuthenticationStateProvider, JwtAuthenticatorProvider>(provider => provider.GetRequiredService<JwtAuthenticatorProvider>());
//builder.Services.AddScoped<ILoginServices, JwtAuthenticatorProvider>(provider => provider.GetRequiredService<JwtAuthenticatorProvider>());
builder.Services.AddBlazoredModal();

await builder.Build().RunAsync();
