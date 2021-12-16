using AutoMapper;
using BuilderCalculatorMVC.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderCalculatorMVC.Application.ViewModels.Clients
{
    public class ClientDetailsVm : IMapFrom<BuilderCalculatorMVC.Domain.Models.Client>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CompanyName { get; set; }
        public string NIP { get; set; }
        public List<ClientsAddressForListVm> Addresses { get; set; }
        public List<ClientsContactDetailsForListVm> PhoneNumbers { get; set; }
        public List<ClientsContactDetailsForListVm> Emails { get; set; }
        public List<ClientsOrderForListVm> Orders { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<BuilderCalculatorMVC.Domain.Models.Client, ClientDetailsVm>()
                .ForMember(dst => dst.Addresses, opt => opt.MapFrom(src => src.Addresses))
                .ForMember(dst => dst.PhoneNumbers, opt => opt.MapFrom(src => src.ContactDetails.Select(c => c.ContactType.Name == "PhoneNumber")))
                .ForMember(dst => dst.Emails, opt => opt.MapFrom(src => src.ContactDetails.Select(c => c.ContactType.Name == "Emails")))
                .ForMember(dst => dst.Orders, opt => opt.MapFrom(src => src.Orders)).ReverseMap();
        }
    }
}
