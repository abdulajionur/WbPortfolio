using Mapster;
using MediatR;
using WbPortfolio.Application.DTO.AboutDtos.Read;
using WbPortfolio.Application.Services.Internal.AboutService.Read;

namespace WbPortfolio.Application.Features.MediatR.About.Queries.GetAboutById;

public class GetAboutByIdQueryHandler : IRequestHandler<GetAboutByIdQuery, IList<GetAboutByIdDto>>
{
    private readonly IReadAboutService _readAboutService;

    public GetAboutByIdQueryHandler(IReadAboutService readAboutService)
    {
        _readAboutService = readAboutService;
    }

    public async Task<IList<GetAboutByIdDto>> Handle(GetAboutByIdQuery request, CancellationToken cancellationToken)
    {
        return await _readAboutService.GetAboutByIdAsync(request.Id, cancellationToken);
    }

}
