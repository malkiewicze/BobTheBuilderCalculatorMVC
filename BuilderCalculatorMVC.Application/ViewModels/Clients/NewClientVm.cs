using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderCalculatorMVC.Application.ViewModels.Clients
{
    public class NewClientVm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CompanyName { get; set; }
        public string NIP { get; set; }
    }
}
