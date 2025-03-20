using Microsoft.Extensions.Configuration;
using WbPortfolio.Entities.ViewModels;

namespace WbPortfolio.Configuration;

public class DomainManager : IDomainService
{
    private readonly IConfiguration configuration;

    public DomainManager(IConfiguration configuration)
    {
        this.configuration = configuration;
    }
    public string Domain()
    {
        string host = configuration.GetSection("Host").Value;
        return host;
    }

}
