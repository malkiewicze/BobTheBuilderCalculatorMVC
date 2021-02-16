using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BobTheBuilderCalculatorMVC.Web.Models
{
    public class RoomModel
    {
        public string RoomName { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public int ID { get; set; }
    }
}
