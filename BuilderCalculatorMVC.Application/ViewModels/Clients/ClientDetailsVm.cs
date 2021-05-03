using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderCalculatorMVC.Application.ViewModels.Clients
{
    public class ClientDetailsVm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CompanyName { get; set; }
        public string NIP { get; set; }
        public List<AddressForListVm> Addresses { get; set; }
        public List<ContactDetailsForListVm> PhoneNumbers { get; set; }
        public List<ContactDetailsForListVm> Emails { get; set; }
        public List<OrderForListVm> Orders { get; set; }
    }
}
