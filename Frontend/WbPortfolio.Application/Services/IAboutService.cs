using WbPortfolio.Entities.ViewModels;

namespace WbPortfolio.Application.Services;

public interface IAboutService
{
    Task<IList<AboutVM>> GetAllAboutAsync(CancellationToken cancellationToken = default);
    Task<IList<AboutVM>> GetAllActiveAboutsAsync(bool isActive = true, CancellationToken cancellationToken = default);
    Task<IList<AboutVM>> GetAboutByIdAsync(Guid Id, CancellationToken cancellationToken = default);
}
