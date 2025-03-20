using WbPortfolio.Application.DTO.AboutDtos.Read;

namespace WbPortfolio.Application.Services.Internal.AboutService.Read;

public interface IReadAboutService
{
    Task<IList<GetAllAboutDto>> GetAllAboutAsync(CancellationToken cancellationToken = default);
    Task<IList<GetAllActiveAboutsDto>> GetAllActiveAboutsAsync(bool isActive = true,CancellationToken cancellationToken = default);
    Task<IList<GetAboutByIdDto>> GetAboutByIdAsync(Guid Id, CancellationToken cancellationToken = default);
}
