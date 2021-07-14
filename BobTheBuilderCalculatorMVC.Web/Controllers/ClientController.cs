using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuilderCalculatorMVC.Application.Interfaces;
using BuilderCalculatorMVC.Application.ViewModels.Clients;
using Microsoft.AspNetCore.Mvc;

namespace BobTheBuilderCalculatorMVC.Web.Controllers
{
    public class ClientController : Controller
    {
        private readonly IClientService _clientService;
        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }
        public IActionResult Index()
        {
            var allClientsModel = _clientService.GetAllClientsForList();
            return View(allClientsModel);
        }

        [HttpGet] //pusty formularz
        public IActionResult AddClient()
        {
            var clientModel = new NewClientVm();
            _clientService.AddClient(clientModel);
            return View(clientModel);
        }

        [HttpPost]
        public IActionResult AddClient(NewClientVm model)
        {
            var id = _clientService.AddClient(model);
            return View();
        }

        [HttpGet]
        public IActionResult AddNewAddressForClient(int clientId)
        {
            var addressModel = new ClientsAddressVm();
           var newAddress =  _clientService.AddNewAddress(addressModel, clientId);
            return View(newAddress);
        }

        [HttpPost]
        public IActionResult AddNewAddressForClient(ClientsAddressVm model)
        {
            return View();
        }

        public IActionResult ViewClient(int clientId)
        {
            var clientModel = _clientService.GetClientDetails(clientId);
            return View(clientModel);
        }
    }
}
