﻿using MediatR;
using WbPortfolio.Api.Endpoints.Definitions;
using WbPortfolio.Domain.Entities;

namespace WbPortfolio.Api.Extensions;

public static class EndpointExtensions
{
    public static void MapEndpoints(this IEndpointRouteBuilder app, IServiceCollection services)
    {
        var endpointDefinitions = typeof(Program).Assembly.GetTypes()
            .Where(t => typeof(IEndpointDefinition).IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract)
            .Select(Activator.CreateInstance)
            .Cast<IEndpointDefinition>();

        foreach (var endpointDefinition in endpointDefinitions)
        {
            endpointDefinition.DefineEndpoints(app);
        }
    }
}
