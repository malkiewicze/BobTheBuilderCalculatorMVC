using AutoMapper;
using BuilderCalculatorMVC.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderCalculatorMVC.Application.ViewModels.Clients
{
    public class NewClientVm : IMapFrom<BuilderCalculatorMVC.Domain.Models.Client>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CompanyName { get; set; }
        public string NIP { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<BuilderCalculatorMVC.Domain.Models.Client, NewClientVm>();//.ReverseMap();

        }
    }
}
