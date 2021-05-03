using BuilderCalculatorMVC.Application.ViewModels;
using BuilderCalculatorMVC.Application.ViewModels.Clients;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderCalculatorMVC.Application.Interfaces
{
    public interface IClientService
    {
        ListClientForListVm GetAllClientsForList();
        int AddClient(NewClientVm client);
        ClientDetailsVm GetClientDetails(int clientId);
    }
}
