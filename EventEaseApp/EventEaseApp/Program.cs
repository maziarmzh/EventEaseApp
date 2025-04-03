using EventEaseApp;
using EventEaseApp.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddSingleton<EventService>();
builder.Services.AddSingleton<UserSessionService>();
builder.Services.AddSingleton<RegistrationService>();
builder.Services.AddScoped<EventService>();
builder.Services.AddSingleton<Tracker>();
builder.Services.AddScoped<Tracker>();

await builder.Build().RunAsync();
