using System.Collections.Generic;

namespace OnDemand.ObjectModel.Models
{
    public class ClientPaymentInformation
    {
        public decimal Amount { get; set; }

        public List<PaymentHistory> History { get; set; }
    }
}
