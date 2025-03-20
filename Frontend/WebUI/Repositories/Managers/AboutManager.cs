using System.Net.Http.Json;
using WebUI.Dtos.AboutDtos;
using WebUI.Repositories.Services;

namespace WebUI.Repositories.Managers;

public class AboutManager : IAboutService
{
    private readonly HttpClient _httpClient;

    public AboutManager(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<AboutDto>> GetAllAbout()
    {
        var response = await _httpClient.GetAsync("/api/Abouts/GetAll");
        if (response.IsSuccessStatusCode)
        {
            var result = await response.Content.ReadFromJsonAsync<List<AboutDto>>();
            return result ?? new List<AboutDto>(); 
        }
        else
        {
            Console.WriteLine($"API Hatası: {response.StatusCode}");
            return new List<AboutDto>();
        }
    }
}
