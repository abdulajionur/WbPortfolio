using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using WbPortfolio.WebUI.Client.Services;


var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7091/") });
builder.Services.AddScoped<DataService>();
builder.Services.AddScoped<NavigationManager>(); // NavigationManager'ı kaydedin

await builder.Build().RunAsync();
