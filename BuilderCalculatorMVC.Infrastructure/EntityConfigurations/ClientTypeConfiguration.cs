using BobTheBuilderCalculatorMVC.Web.Models;
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
                
        }
    }
}
