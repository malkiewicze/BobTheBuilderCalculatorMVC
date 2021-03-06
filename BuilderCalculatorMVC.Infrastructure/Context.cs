﻿using BuilderCalculatorMVC.Domain.Models;
using BuilderCalculatorMVC.Domain.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using BuilderCalculatorMVC.Infrastructure.EntityConfigurations;
using System.Reflection;

namespace BuilderCalculatorMVC.Infrastructure
{
    public class Context : IdentityDbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<ClientType> ClientTypes { get; set; }
        public DbSet<ContactDetail> ContactDetails { get; set; }
        public DbSet<ContactType> ContactTypes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Work> Works { get; set; }
        public DbSet<OrderRoom> OrderRooms { get; set; }
        public DbSet<RoomWork> RoomWorks { get; set; }
        
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }
    }
}
