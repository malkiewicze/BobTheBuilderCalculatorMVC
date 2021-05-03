using BuilderCalculatorMVC.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderCalculatorMVC.Infrastructure.EntityConfigurations
{
    public class WorkConfiguration : BaseEntityConfiguration<Work>
    {
        public override void Configure(EntityTypeBuilder<Work> builder)
        {
            base.Configure(builder);

            builder.HasOne(a => a.CreatedByAppUser)
            .WithMany(a => a.Works)
            .HasForeignKey(a => a.CreatedByAppUserId)
            .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
