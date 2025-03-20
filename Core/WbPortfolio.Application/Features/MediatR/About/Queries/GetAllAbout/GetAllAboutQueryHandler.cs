using MediatR;
using WbPortfolio.Application.DTO.AboutDtos.Read;
using WbPortfolio.Application.Services.Internal.AboutService.Read;

namespace WbPortfolio.Application.Features.MediatR.About.Queries.GetAllAbout;

public class GetAllAboutQueryHandler : IRequestHandler<GetAllAboutQuery, IList<GetAllAboutDto>>
{
    private readonly IReadAboutService _readAboutService;

    public GetAllAboutQueryHandler(IReadAboutService readAboutService)
    {
        _readAboutService = readAboutService;
    }

    public async Task<IList<GetAllAboutDto>> Handle(GetAllAboutQuery request, CancellationToken cancellationToken)
    {
        return await _readAboutService.GetAllAboutAsync(cancellationToken);
    }
}
