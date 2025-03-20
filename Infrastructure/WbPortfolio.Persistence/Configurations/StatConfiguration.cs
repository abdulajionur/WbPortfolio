using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WbPortfolio.Domain.Entities;

namespace WbPortfolio.Persistence.Configurations;

public class StatConfiguration : BaseConfiguration<Stat>
{
    public override void Configure(EntityTypeBuilder<Stat> builder)
    {
        base.Configure(builder);
        builder.HasKey(x => x.Id);
    }
}
