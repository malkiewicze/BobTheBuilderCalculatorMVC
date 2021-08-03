using BuilderCalculatorMVC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderCalculatorMVC.Domain.Models
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public string CreatedByAppUserId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public AppUser CreatedByAppUser { get; set; }
        public AppUser? ModifiedByAppUser { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
    }
}
