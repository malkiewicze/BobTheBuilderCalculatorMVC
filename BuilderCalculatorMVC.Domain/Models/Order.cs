﻿using BuilderCalculatorMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BobTheBuilderCalculatorMVC.Web.Models
{
    public class Order :BaseEntity
    {
        public Client Client { get; set; }
        public int ClientId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public TimeSpan Duration { get; set; }
        public List<Room> Rooms { get; set; }
        public double TotalCost { get; set; }

    }
}