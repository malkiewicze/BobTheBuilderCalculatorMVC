using BobTheBuilderCalculatorMVC.Web.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderCalculatorMVC.Infrastructure.EntityConfigurations
{
    class OrderConfiguration :BaseEntityConfiguration<Order>
    {
        public override void Configure(EntityTypeBuilder<Order> builder)
        {
            base.Configure(builder);

            builder.HasOne(a => a.Client)
                .WithMany(a => a.Orders)
                .HasForeignKey(a => a.ClientId);

            builder.HasMany(a => a.Rooms)
                .WithMany(a => a.Orders);
                
        }
    }
}
