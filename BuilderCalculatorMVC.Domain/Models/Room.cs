using BuilderCalculatorMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BobTheBuilderCalculatorMVC.Web.Models
{
    public class Room : BaseEntity
    {
        public string Name { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public ICollection<Work> Works { get; set; }
        public ICollection<Order> Orders { get; set; }
        public double Cost { get; set; }
    }
}
