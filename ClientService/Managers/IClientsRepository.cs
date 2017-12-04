using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ClientService.Models;

namespace ClientService.Managers
{
    public interface IClientsRepository
    {
        Task<Client> Get(string id);

        Task<IEnumerable<Client>> GetClients(Expression<Func<Client, bool>> filter);

        Task<string> Create(Client client);

        Task Update(string id, Client client);

        Task Delete(string id);
    }
}
