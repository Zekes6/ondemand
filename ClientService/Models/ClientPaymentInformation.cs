using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientService.Models
{
    public class ClientPaymentInformation
    {
        public decimal Amount { get; set; }

        public List<PaymentHistory> History { get; set; }
    }
}
