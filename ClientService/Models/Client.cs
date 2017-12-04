using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientService.Models
{
    public class Client
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public ClientPaymentInformation PaymentInformation { get; set; }

        public List<InsuredItem> Items { get; set; }
    }
}
