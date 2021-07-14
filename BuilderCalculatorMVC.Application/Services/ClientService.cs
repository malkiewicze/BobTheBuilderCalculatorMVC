using BuilderCalculatorMVC.Application.Interfaces;
using BuilderCalculatorMVC.Domain.Interfaces;
using BuilderCalculatorMVC.Application.ViewModels;
using BuilderCalculatorMVC.Application.ViewModels.Clients;
using System;
using System.Collections.Generic;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using System.Linq;
using BuilderCalculatorMVC.Domain.Models;

namespace BuilderCalculatorMVC.Application.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepo;
        //private readonly IAddressRepository _addressRepo;
        private readonly IMapper _mapper;
        

        public ClientService(IClientRepository clientRepo,/* IAddressRepository addressRepo,*/ IMapper mapper)
        {
            _clientRepo = clientRepo;
           // _addressRepo = addressRepo;
            _mapper = mapper;
        }

        public int AddClient(NewClientVm client)
        {
            Client newClient = new Client();
            _mapper.Map(client, newClient);//metoda Map jest używana przy pojedynczym elemencie, inaczej niż ProjectTo
            _clientRepo.AddNew(newClient);
            return newClient.Id;
        }

        public Address AddNewAddress(ClientsAddressVm address, int clientId)
        {
            Address newAddress = new Address();
            var client = _clientRepo.GetById(clientId);
            var clientsAddress = _mapper.Map(address, newAddress);
            client.Addresses.Add(clientsAddress);
            return clientsAddress;
        }

        public ListClientForListVm GetAllClientsForList()
        {
            var clients = _clientRepo.GetAllActiveClients()
                .ProjectTo<ClientForListVm>(_mapper.ConfigurationProvider).ToList();// ProjectTo używany przy IQuerable i kolekcjach
            var clientsList = new ListClientForListVm()
            {
                Clients = clients,
                Count = clients.Count

            };
            return clientsList;
        }

        public ClientDetailsVm GetClientDetails(int clientId)
        {
            var client = _clientRepo.GetById(clientId);
            var clientVm = _mapper.Map<ClientDetailsVm>(client); //metoda Map jest używana przy pojedynczym elemencie, inaczej niż ProjectTo

            return clientVm;
        }

        public ClientsAddressForListVm GetClientsAddress(int clientId)
        {
            var client = _clientRepo.GetById(clientId);
            var clientsAddresses = _mapper.Map<ClientsAddressForListVm>(client);
            return clientsAddresses;

        }

        public ClientsContactDetailsForListVm GetClientsContactDetailsForList(int clientId)
        {
            var client = _clientRepo.GetById(clientId);
            var clientsContacts = _mapper.Map<ClientsContactDetailsForListVm>(client);
            return clientsContacts;
        }

        public ClientsOrderForListVm GetClientsOrderForList(int clientId)
        {
            var client = _clientRepo.GetById(clientId);
            var clientsOrders = _mapper.Map<ClientsOrderForListVm>(client);
            return clientsOrders;
        }

    }

}


