using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderCalculatorMVC.Domain.Models
{
    public class RoomWork :BaseEntity
    {
        public int RoomId { get; set; }
        public Room Room { get; set; }
        public int WorkId { get; set; }
        public Work Work { get; set; }
    }
}
