using BuilderCalculatorMVC.Domain.Model;
using System.Collections.Generic;

namespace BobTheBuilderCalculatorMVC.Web.Models
{
    public class ContactDetail :BaseEntity
    {
        public string ContactInformation { get; set; }
        public string Position { get; set; }
        public virtual ContactType ContactType { get; set; }
        public int ContactTypeId { get; set; }
        public Client Client { get; set; }
        public int ClientId { get; set; }

    }
}