using BuilderCalculatorMVC.Domain.Model;

namespace BuilderCalculatorMVC.Domain.Models
{
    public class Address :BaseEntity
    {
        public string City { get; set; }
        public string Street { get; set; }
        public string BuildingNumber { get; set; }
        public int FlatNumber { get; set; }
        public string ZIPCode { get; set; }
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }

    }
}