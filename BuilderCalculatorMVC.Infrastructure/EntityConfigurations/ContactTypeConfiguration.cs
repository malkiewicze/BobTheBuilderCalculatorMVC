using BuilderCalculatorMVC.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderCalculatorMVC.Infrastructure.EntityConfigurations
{
    public class ContactTypeConfiguration : BaseEntityConfiguration<ContactType>
    {
        public override void Configure(EntityTypeBuilder<ContactType> builder)
        {
            base.Configure(builder);

            builder.HasMany(a => a.ContactDetails)
                .WithOne(a => a.ContactType);

            builder.HasOne(a => a.CreatedByAppUser)
                .WithMany(a => a.ContactTypes)
                .HasForeignKey(a => a.CreatedByAppUserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
