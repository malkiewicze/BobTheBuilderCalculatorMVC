using BuilderCalculatorMVC.Domain.Model;
using System.Collections.Generic;

namespace BobTheBuilderCalculatorMVC.Web.Models
{
    public class Work :BaseEntity
    {
        public string Name { get; set; }
        public string Unit { get; set; }
        public double Rate { get; set; }
        public ICollection<Room> Rooms { get; set; }

    }
}