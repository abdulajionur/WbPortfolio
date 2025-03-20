using Mapster;

namespace WbPortfolio.Application.Mapster.Map;

public abstract class BaseDto<TDto, TEntity> : IRegister where TDto : class, new() where TEntity : class, new()
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<TDto, TEntity>().TwoWays();
    }
}
