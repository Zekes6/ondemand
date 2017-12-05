using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using OnDemand.ObjectModel.Cosmos;
using OnDemand.ObjectModel.Models;

namespace OnDemand.ObjectModel.Managers
{
    public class ClientsRepository : IClientsRepository
    {
        public async Task<Client> Get(string id)
        {
            return await DocumentDBRepository<Client>.GetItemAsync(id);
        }

        public async Task<IEnumerable<Client>> GetClients(Expression<Func<Client, bool>> filter)
        {
            return await DocumentDBRepository<Client>.GetItemsAsync(filter);
        }

        public async Task<string> Create(Client client)
        {
            var doc = await DocumentDBRepository<Client>.CreateItemAsync(client);
            return doc.Id;
        }

        public async Task Update(string id, Client client)
        {
            await DocumentDBRepository<Client>.UpdateItemAsync(id, client);
        }

        public async Task Delete(string id)
        {
            await DocumentDBRepository<Client>.DeleteItemAsync(id);
        }
    }
}
