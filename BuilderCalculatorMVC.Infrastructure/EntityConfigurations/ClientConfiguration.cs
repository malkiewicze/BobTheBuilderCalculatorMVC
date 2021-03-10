using BobTheBuilderCalculatorMVC.Web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderCalculatorMVC.Infrastructure.EntityConfigurations
{
    public class ClientConfiguration : BaseEntityConfiguration<Client>
    {
        public override void Configure(EntityTypeBuilder<Client> builder)
        {
            base.Configure(builder);

            builder.Property(a => a.Name)
               .HasMaxLength(200)
               .IsRequired();

            builder.Property(a => a.Surname)
              .HasMaxLength(200)
              .IsRequired();

            builder.Property(a => a.ContactDetails)
              .HasMaxLength(500)
              .IsRequired();

            builder.HasMany(a => a.Addresses)
                .WithOne(a => a.Client);

            builder.HasMany(a => a.ContactDetails)
               .WithOne(a => a.Client);

            builder.HasMany(a => a.Orders)
              .WithOne(a => a.Client);

            builder.HasOne(a => a.ClientType)
              .WithMany(a => a.Clients);
        }
    }
}
