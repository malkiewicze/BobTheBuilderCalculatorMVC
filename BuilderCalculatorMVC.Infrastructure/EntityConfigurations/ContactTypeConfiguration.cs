using BuilderCalculatorMVC.Domain.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderCalculatorMVC.Infrastructure.EntityConfigurations
{
    class ContactTypeConfiguration :BaseEntityConfiguration<ContactType>
    {
        public override void Configure(EntityTypeBuilder<ContactType> builder)
        {
            base.Configure(builder);

            builder.HasMany(a => a.ContactDetails)
                .WithOne(a => a.ContactType);
        }
    }
}
