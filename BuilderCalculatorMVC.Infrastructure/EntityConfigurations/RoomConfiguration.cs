using BobTheBuilderCalculatorMVC.Web.Models;
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

            builder.HasMany(a => a.Works)
                .WithMany(a => a.Rooms);

            builder.HasMany(a => a.Orders)
                .WithMany(a => a.Rooms);
                                     
        }
    }
}
