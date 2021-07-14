using AutoMapper;
using BuilderCalculatorMVC.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderCalculatorMVC.Application.ViewModels
{
    public class ListClientForListVm : IMapFrom<BuilderCalculatorMVC.Domain.Models.Client>
    {
        public List<ClientForListVm> Clients { get; set; }
        public int Count { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<BuilderCalculatorMVC.Domain.Models.Client, ListClientForListVm>();
        }
    }
}
