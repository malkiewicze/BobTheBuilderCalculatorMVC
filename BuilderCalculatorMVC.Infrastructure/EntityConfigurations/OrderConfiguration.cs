using BuilderCalculatorMVC.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderCalculatorMVC.Infrastructure.EntityConfigurations
{
    public class OrderConfiguration : BaseEntityConfiguration<Order>
    {
        public override void Configure(EntityTypeBuilder<Order> builder)
        {
            base.Configure(builder);

            builder.HasOne(a => a.Client)
                .WithMany(a => a.Orders)
                .HasForeignKey(a => a.ClientId);

            builder.HasOne(a => a.CreatedByAppUser)
                .WithMany(a => a.Orders)
                .HasForeignKey(a => a.CreatedByAppUserId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
