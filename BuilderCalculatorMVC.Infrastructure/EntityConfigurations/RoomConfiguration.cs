using BuilderCalculatorMVC.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderCalculatorMVC.Infrastructure.EntityConfigurations
{
    public class RoomConfiguration :BaseEntityConfiguration<Room>
    {
        public override void Configure(EntityTypeBuilder<Room> builder)
        {
            base.Configure(builder);

            builder.HasOne(a => a.CreatedByAppUser)
           .WithMany(a => a.Rooms)
           .HasForeignKey(a => a.CreatedByAppUserId)
           .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
