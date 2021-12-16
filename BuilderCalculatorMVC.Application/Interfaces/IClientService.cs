using BuilderCalculatorMVC.Application.ViewModels;
using BuilderCalculatorMVC.Application.ViewModels.Clients;
using BuilderCalculatorMVC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderCalculatorMVC.Application.Interfaces
{
    public interface IClientService
    {
        ListClientForListVm GetAllClientsForList(int pageSize, int pageNo, string searchString);
        int AddClient(NewClientVm client);
        ClientDetailsVm GetClientDetails(int clientId);
        ClientsAddressForListVm GetClientsAddress(int clientId);
        public Address AddNewAddress(ClientsAddressVm address, int clientId);
    }
}
