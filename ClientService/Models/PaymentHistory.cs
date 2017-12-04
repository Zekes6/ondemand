using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientService.Models
{
    public class PaymentHistory
    {
        public DateTime PayAt { get; set; }

        public decimal Amount { get; set; }

        public string Description { get; set; }
    }
}
