using AutoMapper;
using BuilderCalculatorMVC.Application.Mapping;
using System;
using System.Linq;

namespace BuilderCalculatorMVC.Application.ViewModels.Clients
{
    public class ClientsOrderForListVm : IMapFrom<BuilderCalculatorMVC.Domain.Models.Client>
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public TimeSpan Duration { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<BuilderCalculatorMVC.Domain.Models.Client, ClientsOrderForListVm>()
                .ForMember(dst => dst.StartDate, opt => opt.MapFrom(src => src.Orders.Select(c => c.StartDate)))
                .ForMember(dst => dst.EndDate, opt => opt.MapFrom(src => src.Orders.Select(c => c.EndDate)))
                .ForMember(dst => dst.Duration, opt => opt.MapFrom(src => src.Orders.Select(c => c.Duration)));
        }

    }
}