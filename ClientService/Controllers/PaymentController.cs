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
    public class PaymentController : Controller
    {
        private IClientsRepository _clientsRepo { get; set; }

        public PaymentController(IClientsRepository clientsRepository)
        {
            _clientsRepo = clientsRepository;
        }

        [HttpPost]
        public async Task<Client> AddPayment(string clientId, decimal amount)
        {
            var client = await _clientsRepo.Get(clientId);

            if (client == null) return null;

            if (client.PaymentInformation == null)
            {
                client.PaymentInformation = new ClientPaymentInformation();
            }

            client.PaymentInformation.Amount += amount;

            await _clientsRepo.Update(clientId, client);

            return client;
        }
    }
}
