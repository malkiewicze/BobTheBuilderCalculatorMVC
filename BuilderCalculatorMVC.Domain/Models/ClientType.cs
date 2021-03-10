using BuilderCalculatorMVC.Domain.Model;
using System.Collections.Generic;

namespace BobTheBuilderCalculatorMVC.Web.Models
{
    public class ClientType :BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
    }
}