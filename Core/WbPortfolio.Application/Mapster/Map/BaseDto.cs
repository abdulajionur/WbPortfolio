using Mapster;
using WbPortfolio.Application.DTO.AboutDtos.Read;
using WbPortfolio.Domain.Entities;

namespace WbPortfolio.Application.Mapster.Map;
/// <summary>
/// DTO ve Entity tipleri arasında çift yönlü (TwoWays) mapping yapılandırması sağlayan base sınıf.
/// </summary>
/// <typeparam name="TDto">DTO tipi.</typeparam>
/// <typeparam name="TEntity">Entity tipi.</typeparam>
public abstract class BaseDto<TDto, TEntity> : IRegister where TDto : class, new() where TEntity : class, new()
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<TDto, TEntity>().TwoWays();

    }
}
