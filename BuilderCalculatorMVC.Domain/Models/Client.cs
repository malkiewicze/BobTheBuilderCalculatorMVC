using BuilderCalculatorMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuilderCalculatorMVC.Domain.Models
{
    public class Client : BaseEntity
    {
        public int ClientTypeId { get; set; }

        public virtual ClientType ClientType { get; set; }
        public string? CompanyName { get; set; }
        public string? NIP { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<ContactDetail> ContactDetails { get; set; }
        public virtual ICollection<Order> Orders { get; set; }

    }
}
