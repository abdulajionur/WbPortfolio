using Microsoft.AspNetCore.SignalR;
using WbPortfolio.Application.Services;

namespace WbPortfolio.Application.Hubs;

public class AboutHub : Hub
{
    private readonly IAboutService _aboutService;
    public AboutHub(IAboutService aboutService)
    {
        _aboutService = aboutService;
    }
    public async Task SendAboutList()
    {
        var abouts = await _aboutService.GetAllAboutAsync();
        await Clients.All.SendAsync("ReceiveAboutList", abouts);
    }

    // Veri değişikliği olduğunda bu metodu çağırın (örneğin, bir güncelleme işleminden sonra)
    public async Task NotifyAboutListChanged()
    {
        await SendAboutList();
    }
}
