using BuilderCalculatorMVC.Domain.Model;
using System.Collections.Generic;

namespace BuilderCalculatorMVC.Domain.Models
{
    public class Work :BaseEntity
    {
        public string Name { get; set; }
        public string Unit { get; set; }
        public double Rate { get; set; }
        public ICollection<RoomWork> RoomWorks { get; set; }

    }
}