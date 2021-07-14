using AutoMapper;
using BuilderCalculatorMVC.Application.Mapping;
using System.Linq;

namespace BuilderCalculatorMVC.Application.ViewModels.Clients
{
    public class ClientsAddressForListVm : IMapFrom<BuilderCalculatorMVC.Domain.Models.Client>
    {
        public string City { get; set; }
        public string Street { get; set; }
        public string BuildingNumber { get; set; }
        public int FlatNumber { get; set; }
        public string ZIPCode { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<BuilderCalculatorMVC.Domain.Models.Client, ClientsAddressForListVm>()
                .ForMember(dst => dst.City, opt => opt.MapFrom(src => src.Addresses.Select(c => c.City)))
                .ForMember(dst => dst.Street, opt => opt.MapFrom(src => src.Addresses.Select(c => c.Street)))
                .ForMember(dst => dst.BuildingNumber, opt => opt.MapFrom(src => src.Addresses.Select(c => c.BuildingNumber)))
                .ForMember(dst => dst.FlatNumber, opt => opt.MapFrom(src => src.Addresses.Select(c => c.FlatNumber)))
                .ForMember(dst => dst.ZIPCode, opt => opt.MapFrom(src => src.Addresses.Select(c => c.ZIPCode)));

        }
    }
}