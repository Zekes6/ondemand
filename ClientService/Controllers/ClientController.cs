using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnDemand.ObjectModel.Managers;
using OnDemand.ObjectModel.Models;

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

            client.Items.ForEach((item) =>
            {
                item.InsuredTotal = item.InsuredCost *
                                    Convert.ToDecimal(Math.Ceiling((DateTime.UtcNow - item.StartInsuredAt).TotalHours));
            });

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
