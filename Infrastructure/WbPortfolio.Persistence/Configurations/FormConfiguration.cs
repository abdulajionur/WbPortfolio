﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WbPortfolio.Domain.Entities;

namespace WbPortfolio.Persistence.Configurations;

public class FormConfiguration : BaseConfiguration<Form>
{
    public override void Configure(EntityTypeBuilder<Form> builder)
    {
        base.Configure(builder);

        builder.HasKey(x => x.Id);

        builder.Property(x => x.FormName)
            .IsRequired();

        builder.Property(x => x.FormEmail)
            .IsRequired();

        builder.Property(x => x.FormSubject)
            .IsRequired();

        builder.Property(x => x.FormMessage)
            .IsRequired();

        builder.Property(x => x.FormSendDate)
            .IsRequired();
    }
}
