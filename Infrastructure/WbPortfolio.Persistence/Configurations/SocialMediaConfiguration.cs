using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WbPortfolio.Domain.Entities;

namespace WbPortfolio.Persistence.Configurations;

public class SocialMediaConfiguration : BaseConfiguration<SocialMedia>
{
    public override void Configure(EntityTypeBuilder<SocialMedia> builder)
    {
        base.Configure(builder);
        builder.HasKey(x => x.Id);
    }
}
