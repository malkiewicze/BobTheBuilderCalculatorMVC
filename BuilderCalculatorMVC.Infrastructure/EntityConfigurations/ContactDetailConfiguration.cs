using BuilderCalculatorMVC.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderCalculatorMVC.Infrastructure.EntityConfigurations
{
    public class ContactDetailConfiguration : BaseEntityConfiguration<ContactDetail>
    {
        public override void Configure(EntityTypeBuilder<ContactDetail> builder)
        {
            base.Configure(builder);

            builder.HasOne(a => a.Client)
                .WithMany(a => a.ContactDetails)
                .HasForeignKey(a => a.ClientId);

            builder.HasOne(a => a.ContactType)
                .WithMany(a => a.ContactDetails)
                .HasForeignKey(a => a.ContactTypeId);

            builder.HasOne(a => a.CreatedByAppUser)
                .WithMany(a => a.ContactDetails)
                .HasForeignKey(a => a.CreatedByAppUserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
