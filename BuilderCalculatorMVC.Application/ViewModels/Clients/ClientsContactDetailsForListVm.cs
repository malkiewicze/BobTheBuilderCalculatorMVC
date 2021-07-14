using AutoMapper;
using BuilderCalculatorMVC.Application.Mapping;
using BuilderCalculatorMVC.Domain.Model;
using System.Linq;

namespace BuilderCalculatorMVC.Application.ViewModels.Clients
{
    public class ClientsContactDetailsForListVm : IMapFrom<BuilderCalculatorMVC.Domain.Models.Client>
    {
        public ContactType ContactType { get; set; }
        public string ContactInformation { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<BuilderCalculatorMVC.Domain.Models.Client, ClientsContactDetailsForListVm>()
              .ForMember(dst => dst.ContactType, opt => opt.MapFrom(src => src.ContactDetails.Select(c =>c.ContactType.Name)))
              .ForMember(dst => dst.ContactInformation, opt => opt.MapFrom(src => src.ContactDetails.Select(c => c.ContactInformation)));

        }
    }
}