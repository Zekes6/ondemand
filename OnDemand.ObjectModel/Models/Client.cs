using System.Collections.Generic;

namespace OnDemand.ObjectModel.Models
{
    public class Client
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public ClientPaymentInformation PaymentInformation { get; set; }

        public List<InsuredItem> Items { get; set; }
    }
}
