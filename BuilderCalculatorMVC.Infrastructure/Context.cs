using BuilderCalculatorMVC.Domain.Models;
using BuilderCalculatorMVC.Domain.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderCalculatorMVC.Infrastructure
{
    public class Context : IdentityDbContext
    {

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<ClientType> ClientTypes { get; set; }
        public DbSet<ContactDetail> ContactDetails { get; set; }
        public DbSet<ContactType> ContactTypes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Work> Works { get; set; }
        public DbSet<BaseEntity> BaseEntities { get; set; }

        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ContactDetail>()
            .HasOne<Client>(t => t.Client)
            .WithMany(z => z.ContactDetails)
            .HasForeignKey(it => it.ClientId);

            builder.Entity<Address>()
            .HasOne<Client>(t => t.Client)
            .WithMany(z => z.Addresses)
            .HasForeignKey(it => it.ClientId);

            builder.Entity<OrderRoom>().HasKey(or => new { or.OrderId, or.RoomId });

            builder.Entity<OrderRoom>()
                .HasOne<Order>(or => or.Order)
                .WithMany(o => o.OrderRooms)
                .HasForeignKey(or => or.OrderId);

            builder.Entity<OrderRoom>()
                .HasOne<Room>(or => or.Room)
                .WithMany(o => o.OrderRooms)
                .HasForeignKey(or => or.RoomId);

            builder.Entity<RoomWork>().HasKey(or => new { or.RoomId, or.WorkId });

            builder.Entity<RoomWork>()
                .HasOne<Work>(or => or.Work)
                .WithMany(o => o.RoomWorks)
                .HasForeignKey(or => or.WorkId);

            builder.Entity<RoomWork>()
                .HasOne<Room>(or => or.Room)
                .WithMany(o => o.RoomWorks)
                .HasForeignKey(or => or.RoomId);
        }
    }
}
