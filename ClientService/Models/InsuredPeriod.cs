using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientService.Models
{
    public class InsuredPeriod
    {
        public DateTime StartAt { get; set; }

        public DateTime EndAt { get; set; }

        public decimal SumCost { get; set; }
    }
}
