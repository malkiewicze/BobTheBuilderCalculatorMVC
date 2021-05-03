using BuilderCalculatorMVC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderCalculatorMVC.Domain.Models
{
    public class OrderRoom : BaseEntity
    {
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }
    }
}
