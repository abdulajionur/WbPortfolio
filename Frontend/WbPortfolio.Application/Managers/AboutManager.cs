using System.Net.Http.Json;
using System.Text.Json;
using WbPortfolio.Application.Services;
using WbPortfolio.Configuration;
using WbPortfolio.Entities.ViewModels;

namespace WbPortfolio.Application.Managers;

public class AboutManager : IAboutService
{
    private readonly IDomainService _domainService;
    private readonly HttpClient _httpClient;

    public AboutManager(IDomainService domainService, HttpClient httpClient)
    {
        _domainService = domainService;
        _httpClient = httpClient;
    }

    public Task<IList<AboutVM>> GetAboutByIdAsync(Guid Id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public async Task<IList<AboutVM>> GetAllAboutAsync(CancellationToken cancellationToken = default)
    {
        var result = await _httpClient.GetFromJsonAsync<IList<AboutVM>>(_domainService.Domain() + "/api/Abouts/GetAll");
        return result ?? new List<AboutVM>();
    }

    public Task<IList<AboutVM>> GetAllActiveAboutsAsync(bool isActive = true, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}
