using BuilderCalculatorMVC.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderCalculatorMVC.Infrastructure.EntityConfigurations
{
    public class ClientTypeConfiguration : BaseEntityConfiguration<ClientType>
    {
        public override void Configure(EntityTypeBuilder<ClientType> builder)
        {
            base.Configure(builder);

            builder.HasMany(a => a.Clients)
                .WithOne(a => a.ClientType);

            builder.HasOne(a => a.CreatedByAppUser)
                .WithMany(a => a.ClientTypes)
                .HasForeignKey(a => a.CreatedByAppUserId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
