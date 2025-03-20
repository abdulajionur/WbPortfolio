using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WbPortfolio.Domain.Interfaces.IRepositories.AboutRepo;
using WbPortfolio.Domain.Interfaces.IRepositories.Read;
using WbPortfolio.Domain.Interfaces.IRepositories.Write;
using WbPortfolio.Domain.Interfaces.IUnitOfWorks;
using WbPortfolio.Persistence.Context.Data;
using WbPortfolio.Persistence.Repositories.Read;
using WbPortfolio.Persistence.Repositories.Repos.AboutRepo;
using WbPortfolio.Persistence.Repositories.UnitOfWorks;
using WbPortfolio.Persistence.Repositories.Write;

namespace WbPortfolio.Persistence.Extensions;

public static class PersistenceExtension
{
    public static void AddPersistenceLayer(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        });

        services.AddScoped(typeof(IReadRepository<>), typeof(ReadRepository<>));
        services.AddScoped(typeof(IWriteRepository<>), typeof(WriteRepository<>));

        services.AddScoped<IUnitOfWork, UnitOfWork>();

        services.AddScoped<IAboutReadRepository, AboutReadRepository>();
        services.AddScoped<IAboutWriteRepository, AboutWriteRepository>();
    }
}
