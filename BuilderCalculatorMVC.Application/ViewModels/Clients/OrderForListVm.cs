using System;

namespace BuilderCalculatorMVC.Application.ViewModels.Clients
{
    public class OrderForListVm
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public TimeSpan Duration { get; set; }
    }
}