using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WbPortfolio.Domain.Entities;

namespace WbPortfolio.Persistence.Configurations;

public class SummaryConfiguration : BaseConfiguration<Summary>
{
    public override void Configure(EntityTypeBuilder<Summary> builder)
    {
        base.Configure(builder);
        builder.HasKey(x => x.Id);
    }
}
