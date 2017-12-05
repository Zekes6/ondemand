using System;
using System.Collections.Generic;

namespace OnDemand.ObjectModel.Models
{
    public class InsuredItem
    {
        public string Id { get; set; }

        public decimal Cost { get; set; }

        public string Name { get; set; }

        public bool IsInsured { get; set; }

        public DateTime StartInsuredAt { get; set; }

        public string ClassifiedId { get; set; }
        
        public decimal InsuredCost { get; set; }

        public decimal InsuredTotal { get; set; }

        public ItemStatus Status { get; set; }

        public List<ItemPhoto> Photos { get; set; }

        public List<InsuredPeriod> History { get; set; }
    }
}
