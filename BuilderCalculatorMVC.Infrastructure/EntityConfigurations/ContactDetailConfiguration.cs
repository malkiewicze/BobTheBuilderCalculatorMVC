using BobTheBuilderCalculatorMVC.Web.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderCalculatorMVC.Infrastructure.EntityConfigurations
{
    class ContactDetailConfiguration : BaseEntityConfiguration<ContactDetail>
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
        }
    }
}
