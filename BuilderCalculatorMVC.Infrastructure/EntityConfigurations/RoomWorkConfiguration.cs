using BuilderCalculatorMVC.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderCalculatorMVC.Infrastructure.EntityConfigurations
{
    public class RoomWorkConfiguration : BaseEntityConfiguration<RoomWork>
    {
        public override void Configure(EntityTypeBuilder<RoomWork> builder)
        {
            base.Configure(builder);

            builder.HasKey(or => new { or.RoomId, or.WorkId });

            builder.HasOne<Work>(or => or.Work)
                .WithMany(o => o.RoomWorks)
                .HasForeignKey(or => or.WorkId);

            builder.HasOne<Room>(or => or.Room)
                .WithMany(o => o.RoomWorks)
                .HasForeignKey(or => or.RoomId);

            builder.HasOne(a => a.CreatedByAppUser)
            .WithMany(a => a.RoomWorks)
            .HasForeignKey(a => a.CreatedByAppUserId)
            .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
