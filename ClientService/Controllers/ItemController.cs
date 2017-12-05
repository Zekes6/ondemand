using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnDemand.ObjectModel.Managers;
using OnDemand.ObjectModel.Models;

namespace ClientService.Controllers
{
    [Route("api/items")]
    public class ItemController : Controller
    {
        private IClientsRepository _clientsRepo { get; set; }

        public ItemController(IClientsRepository clientsRepository)
        {
            _clientsRepo = clientsRepository;
        }

        [Route("new")]
        [HttpPost]
        public async Task<Client> Create(string clientId, string name)
        {
            var item = new InsuredItem()
            {
                Name = name,
                IsInsured = false
            };

            var client = await _clientsRepo.Get(clientId);

            if (client.Items == null)
            {
                client.Items = new List<InsuredItem>();
            }

            client.Items.Add(item);

            await _clientsRepo.Update(clientId, client);

            return client;
        }

        [Route("protect")]
        [HttpPost]
        public async Task<StatusCodeResult> ChangeInsurance(string clientId, string itemId)
        {
            var client = await _clientsRepo.Get(clientId);

            var item = client.Items.FirstOrDefault(c => c.Id == itemId);

            if (item == null)
            {
                return StatusCode(404);
            }

            if (item.IsInsured)
            {
                var period = DateTime.UtcNow - item.StartInsuredAt;
                var totalHours = Convert.ToDecimal(Math.Ceiling(period.TotalHours));

                client.PaymentInformation.Amount -= totalHours * item.InsuredCost;

                item.IsInsured = false;
            }
            else
            {
                item.IsInsured = true;
                item.StartInsuredAt = DateTime.UtcNow;
            }

            await _clientsRepo.Update(clientId, client);

            return StatusCode(200);
        }
    }
}
