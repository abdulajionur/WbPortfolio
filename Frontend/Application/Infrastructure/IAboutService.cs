using Shared.Data;

namespace Application.Infrastructure;

public interface IAboutService
{
    public Task<AboutDto> GetAboutById(Guid id);
    public Task<List<AboutDto>> GetAbouts();
    public Task<AboutDto> CreateAbout(AboutDto aboutDto);
    public Task<AboutDto> UpdateAbout(AboutDto aboutDto);
    public Task<bool> DeleteAboutByID(Guid id);
}
