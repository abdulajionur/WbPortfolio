using FluentValidation;
using Mapster;
using MapsterMapper;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using WbPortfolio.Application.DTO.AboutDtos.Read;
using WbPortfolio.Application.Features.MediatR.About.Queries.GetAllActiveAbout;
using WbPortfolio.Application.Services.Internal.AboutService.Read;
using WbPortfolio.Application.Validators;

namespace WbPortfolio.Application.Extensions;

public static class ApplicationExtension
{
    public static IServiceCollection AddApplicationLayer(this IServiceCollection services)
    {
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));

        var config = TypeAdapterConfig.GlobalSettings;
        config.Scan(Assembly.GetExecutingAssembly());
        services.AddSingleton(config);
        services.AddScoped<IMapper, ServiceMapper>();

        services.AddValidatorsFromAssemblies(new[] { Assembly.GetExecutingAssembly() });
        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));

        services.AddScoped<IReadAboutService, ReadAboutManager>();

        return services;
    }
}
