using System;

namespace OnDemand.ObjectModel.Models
{
    public class PaymentHistory
    {
        public DateTime PayAt { get; set; }

        public decimal Amount { get; set; }

        public string Description { get; set; }
    }
}
