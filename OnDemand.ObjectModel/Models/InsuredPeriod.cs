using System;

namespace OnDemand.ObjectModel.Models
{
    public class InsuredPeriod
    {
        public DateTime StartAt { get; set; }

        public DateTime EndAt { get; set; }

        public decimal SumCost { get; set; }
    }
}
