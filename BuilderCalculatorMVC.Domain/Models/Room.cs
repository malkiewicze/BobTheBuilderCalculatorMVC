using BuilderCalculatorMVC.Domain.Model;
using BuilderCalculatorMVC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuilderCalculatorMVC.Domain.Models
{
    public class Room : BaseEntity
    {
        public string Name { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public ICollection<RoomWork> RoomWorks { get; set; }
        public ICollection<OrderRoom> OrderRooms { get; set; }
        public double Cost { get; set; }
    }
}
