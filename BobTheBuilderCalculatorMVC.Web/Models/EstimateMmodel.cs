using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BobTheBuilderCalculatorMVC.Web.Models
{
    public class EstimateModel
    {
        public int IdNumber { get; set; }
        public int NumberOfRooms { get; set; }
        public List<RoomModel> Rooms { get; set; }
        public double TotalCost { get; set; }

    }
}
