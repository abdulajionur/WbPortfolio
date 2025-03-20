using Blazored.Toast;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.AspNetCore.SignalR.Client;
using Radzen;
using WbPortfolio.Application.Managers;
using WbPortfolio.Application.Services;
using WbPortfolio.Configuration;
using WbPortfolio.WebUI;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddRadzenComponents();
builder.Services.AddBlazoredToast();
builder.Services.AddBootstrapBlazor();
builder.Services.AddScoped<HubConnection>(sp =>
    new HubConnectionBuilder()
        .WithUrl($"{sp.GetRequiredService<NavigationManager>().BaseUri}aboutHub")
        .WithAutomaticReconnect()
        .Build());


#region Components

builder.Services.AddScoped<DialogService>();
builder.Services.AddScoped<NotificationService>();
builder.Services.AddScoped<TooltipService>();
builder.Services.AddScoped<ContextMenuService>();

#endregion

#region Configuration

builder.Services.AddScoped<IDomainService,DomainManager>();

#endregion

builder.Services.AddScoped<IAboutService, AboutManager>();

await builder.Build().RunAsync();
