using WebUI.Dtos.AboutDtos;

namespace WebUI.Repositories.Services;

public interface IAboutService
{
    Task<List<AboutDto>> GetAllAbout();
}
