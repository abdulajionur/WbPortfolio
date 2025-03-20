using Mapster;
using WbPortfolio.Application.DTO.AboutDtos.Read;
using WbPortfolio.Domain.Entities;
using WbPortfolio.Domain.Interfaces.IUnitOfWorks;

namespace WbPortfolio.Application.Services.Internal.AboutService.Read;

public class ReadAboutManager : IReadAboutService
{
    private readonly IUnitOfWork _unitOfWork;

    public ReadAboutManager(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    public async Task<IList<GetAllAboutDto>> GetAllAboutAsync(CancellationToken cancellationToken)
    {
        var abouts = await _unitOfWork.AboutReadRepository.GetAllAsync(cancellationToken: cancellationToken);
        return abouts.Adapt<IList<GetAllAboutDto>>();
    }

    public async Task<IList<GetAllActiveAboutsDto>> GetAllActiveAboutsAsync(bool isActive = true, CancellationToken cancellationToken = default)
    {
        var abouts = await _unitOfWork.AboutReadRepository.GetAllAsync(isActive: isActive, cancellationToken: cancellationToken);
        return abouts.Adapt<IList<GetAllActiveAboutsDto>>();
    }

    public async Task<IList<GetAboutByIdDto>> GetAboutByIdAsync(Guid Id, CancellationToken cancellationToken)
    {
        var abouts = await _unitOfWork.AboutReadRepository.GetByIdAsync(Id, cancellationToken: cancellationToken);
        return new List<GetAboutByIdDto> { abouts.Adapt<GetAboutByIdDto>() }; // Tek elemanlı liste döndür.
    }
}
