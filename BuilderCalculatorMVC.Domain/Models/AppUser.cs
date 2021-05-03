using BuilderCalculatorMVC.Domain.Model;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderCalculatorMVC.Domain.Models
{
    public class AppUser : IdentityUser
    {
        public ICollection<Address> Addresses { get; set; }
        public ICollection<Client> Clients { get; set; }
        public ICollection<ClientType> ClientTypes { get; set; }
        public ICollection<ContactDetail> ContactDetails { get; set; }
        public ICollection<ContactType> ContactTypes { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<Work> Works { get; set; }
        public ICollection<Room> Rooms { get; set; }
        public ICollection<OrderRoom> OrderRooms { get; set; }
        public ICollection<RoomWork> RoomWorks { get; set; }


    }
}
