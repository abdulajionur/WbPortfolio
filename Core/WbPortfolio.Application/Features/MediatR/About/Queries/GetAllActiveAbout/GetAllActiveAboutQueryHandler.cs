using MediatR;
using WbPortfolio.Application.DTO.AboutDtos.Read;
using WbPortfolio.Application.Services.Internal.AboutService.Read;

namespace WbPortfolio.Application.Features.MediatR.About.Queries.GetAllActiveAbout;

public class GetAllActiveAboutQueryHandler : IRequestHandler<GetAllActiveAboutQuery, IList<GetAllActiveAboutsDto>>
{
    private readonly IReadAboutService _readAboutService;

    public GetAllActiveAboutQueryHandler(IReadAboutService readAboutService)
    {
        _readAboutService = readAboutService;
    }

    public async Task<IList<GetAllActiveAboutsDto>> Handle(GetAllActiveAboutQuery request, CancellationToken cancellationToken)
    {
        var list = await _readAboutService.GetAllActiveAboutsAsync(request.IsActive = true, cancellationToken);
        return list;
    }
}
