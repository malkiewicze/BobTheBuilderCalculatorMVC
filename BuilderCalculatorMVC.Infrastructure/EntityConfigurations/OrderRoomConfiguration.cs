using BuilderCalculatorMVC.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderCalculatorMVC.Infrastructure.EntityConfigurations
{
    public class OrderRoomConfiguration : BaseEntityConfiguration<OrderRoom>
    {
        public override void Configure(EntityTypeBuilder<OrderRoom> builder)
        {
            base.Configure(builder);

            builder.HasKey(or => new { or.OrderId, or.RoomId });

            builder.HasOne<Order>(or => or.Order)
               .WithMany(o => o.OrderRooms)
               .HasForeignKey(or => or.OrderId);

            builder.HasOne<Room>(or => or.Room)
                .WithMany(o => o.OrderRooms)
                .HasForeignKey(or => or.RoomId);

            builder.HasOne(a => a.CreatedByAppUser)
            .WithMany(a => a.OrderRooms)
            .HasForeignKey(a => a.CreatedByAppUserId)
            .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
