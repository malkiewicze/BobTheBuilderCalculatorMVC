using BobTheBuilderCalculatorMVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderCalculatorMVC.Domain.Model
{
    public class ContactType :BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<ContactDetail> ContactDetails { get; set; }
    }
}
