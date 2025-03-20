using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WbPortfolio.Domain.Entities;

namespace WbPortfolio.Persistence.Configurations;

public class ResumeConfiguration : BaseConfiguration<Resume>
{
    public override void Configure(EntityTypeBuilder<Resume> builder)
    {
        base.Configure(builder);
        builder.HasKey(x => x.Id);
    }
}
