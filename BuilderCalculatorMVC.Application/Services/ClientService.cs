using BuilderCalculatorMVC.Application.Interfaces;
using BuilderCalculatorMVC.Domain.Interfaces;
using BuilderCalculatorMVC.Application.ViewModels;
using BuilderCalculatorMVC.Application.ViewModels.Clients;
using System;
using System.Collections.Generic;

namespace BuilderCalculatorMVC.Application.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepo;

        #region AddCLient
        public int AddClient(NewClientVm client)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region GetAllActiveClients
        public ListClientForListVm GetAllClientsForList()
        {
            var clients = _clientRepo.GetAllActiveClients();
            ListClientForListVm result = new ListClientForListVm();
            result.Clients = new List<ClientForListVm>();
            foreach (var client in clients)
            {
                var clientVm = new ClientForListVm()
                {
                    Id = client.Id,
                    Name = client.Name,
                    Surname = client.Surname,
                };
                result.Clients.Add(clientVm);
            }
            result.Count = result.Clients.Count;
            return result;
        }
        #endregion

        #region GetClientDetails
        public ClientDetailsVm GetClientDetails(int clientId)
        {
            var client = _clientRepo.GetEntityById(clientId);
            var clientVm = new ClientDetailsVm();
            clientVm.Id = client.Id;
            clientVm.Name = client.Name;
            clientVm.Surname = client.Surname;
            clientVm.CompanyName = client.CompanyName;
            clientVm.NIP = client.NIP;
            clientVm.Addresses = new List<AddressForListVm>();
            clientVm.Emails = new List<ContactDetailsForListVm>();
            clientVm.PhoneNumbers = new List<ContactDetailsForListVm>();
            clientVm.Orders = new List<OrderForListVm>();

            foreach (var address in client.Addresses)
            {
                var add = new AddressForListVm()
                {
                    City = address.City,
                    Street = address.Street,
                    BuildingNumber = address.BuildingNumber,
                    FlatNumber = address.FlatNumber,
                    ZIPCode = address.ZIPCode
                };
                clientVm.Addresses.Add(add);
            }

            foreach (var email in client.ContactDetails)
            {
                if (client.ClientType.Name == "email")
                {
                    var add = new ContactDetailsForListVm()
                    {
                        ContactType = email.ContactType,
                        ContactInformation = email.ContactInformation
                    };
                    clientVm.Emails.Add(add);
                }
            }

            foreach (var phoneNumber in client.ContactDetails)
            {
                if (client.ClientType.Name == "phonenUmber")
                {
                    var add = new ContactDetailsForListVm()
                    {
                        ContactType = phoneNumber.ContactType,
                        ContactInformation = phoneNumber.ContactInformation
                    };
                    clientVm.PhoneNumbers.Add(add);
                }
            }

            foreach (var order in client.Orders)
            {
                var add = new OrderForListVm()
                {
                    Id = order.Id,
                    StartDate = order.StartDate,
                    EndDate = order.EndDate,
                    Duration = order.Duration
                };
                clientVm.Orders.Add(add);
            }

            return clientVm;
        }
        #endregion
    }
}

