using MediatR;
using WbPortfolio.Application.DTO.AboutDtos.Read;

namespace WbPortfolio.Application.Features.MediatR.About.Queries.GetAllActiveAbout;

public class GetAllActiveAboutQuery : IRequest<IList<GetAllActiveAboutsDto>>
{
    public bool IsActive { get; set; }
}
