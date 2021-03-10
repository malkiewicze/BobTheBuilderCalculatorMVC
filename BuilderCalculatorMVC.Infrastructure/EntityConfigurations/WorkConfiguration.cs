using BobTheBuilderCalculatorMVC.Web.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderCalculatorMVC.Infrastructure.EntityConfigurations
{
    public class WorkConfiguration :BaseEntityConfiguration<Work>
    {
        public override void Configure(EntityTypeBuilder<Work> builder)
        {
            base.Configure(builder);
            builder.Property(a => a.Name)
                .IsRequired();

            builder.HasMany(a => a.Rooms)
                .WithMany(a => a.Works);

        }
    }
}
