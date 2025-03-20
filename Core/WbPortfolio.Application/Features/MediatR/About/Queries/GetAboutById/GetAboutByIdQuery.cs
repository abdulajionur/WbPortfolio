using MediatR;
using WbPortfolio.Application.DTO.AboutDtos.Read;

namespace WbPortfolio.Application.Features.MediatR.About.Queries.GetAboutById;

public class GetAboutByIdQuery : IRequest<IList<GetAboutByIdDto>>
{
    public Guid Id { get; set; }
    public GetAboutByIdQuery(Guid id)
    {
        Id = id;
    }
}
