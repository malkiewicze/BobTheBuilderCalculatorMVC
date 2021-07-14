using AutoMapper;
using BuilderCalculatorMVC.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderCalculatorMVC.Application.ViewModels.Clients
{
    public class ClientsAddressVm : IMapFrom<BuilderCalculatorMVC.Domain.Models.Address>
    {
        public string City { get; set; }
        public string Street { get; set; }
        public string BuildingNumber { get; set; }
        public int FlatNumber { get; set; }
        public string ZIPCode { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<BuilderCalculatorMVC.Domain.Models.Address, ClientsAddressVm>();

        }
    }
}
