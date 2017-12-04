using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClientService.Managers;
using ClientService.Models;
using Microsoft.AspNetCore.Mvc;

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

            item.IsInsured = !item.IsInsured;

            return StatusCode(200);
        }
    }
}
