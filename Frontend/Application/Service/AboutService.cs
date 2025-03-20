using Application.Infrastructure;
using Shared.Data;

namespace Application.Service;

public class AboutService : IAboutService
{
    public Task<AboutDto> CreateAbout(AboutDto aboutDto)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteAboutByID(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<AboutDto> GetAboutById(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<List<AboutDto>> GetAbouts()
    {
        throw new NotImplementedException();
    }

    public Task<AboutDto> UpdateAbout(AboutDto aboutDto)
    {
        throw new NotImplementedException();
    }
}
