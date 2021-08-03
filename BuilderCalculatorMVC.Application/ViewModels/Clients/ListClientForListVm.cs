using AutoMapper;
using BuilderCalculatorMVC.Application.Mapping;
using BuilderCalculatorMVC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderCalculatorMVC.Application.ViewModels
{
    public class ListClientForListVm : IMapFrom<ClientForListVm>
    {
        public List<ClientForListVm> Clients { get; set; }
        public int Count { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<ClientForListVm, ListClientForListVm>();

        }
    }
}
