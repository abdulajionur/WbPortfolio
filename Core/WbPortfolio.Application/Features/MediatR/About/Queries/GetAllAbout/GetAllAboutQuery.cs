using MediatR;
using WbPortfolio.Application.DTO.AboutDtos.Read;

namespace WbPortfolio.Application.Features.MediatR.About.Queries.GetAllAbout;

public class GetAllAboutQuery : IRequest<IList<GetAllAboutDto>>
{
}


//public class GetAboutByIdQuery : IRequest<GetAboutByIdDto?>
//{
//    public Guid Id { get; set; }
//}