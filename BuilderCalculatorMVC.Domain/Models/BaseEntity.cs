using BobTheBuilderCalculatorMVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderCalculatorMVC.Domain.Model
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public string CreatedByAppUserId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public string ModifiedByAppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public DateTime ModifiedDateTime { get; set; }
    }
}
