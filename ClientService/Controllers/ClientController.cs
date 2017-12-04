using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClientService.Managers;
using ClientService.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClientService.Controllers
{
    [Route("api/[controller]")]
    public class ClientController : Controller
    {
        private IClientsRepository _clientsRepo { get; set; }

        public ClientController(IClientsRepository clientsRepository)
        {
            _clientsRepo = clientsRepository;
        }

        [Route("{clientId}")]
        [HttpGet]
        public async Task<Client> Get(string clientId)
        {
            var client = await _clientsRepo.Get(clientId);

            return client;
        }

        [Route("new")]
        [HttpPost]
        public async Task<string> Register(string name)
        {
            var document = await _clientsRepo.Create(new Client()
            {
                Name = name,
                PaymentInformation = new ClientPaymentInformation()
                {
                    Amount = 0,
                    History = new List<PaymentHistory>()
                }
            });

            return document;
        }
    }
}
