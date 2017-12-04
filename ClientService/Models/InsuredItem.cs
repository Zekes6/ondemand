using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientService.Models
{
    public class InsuredItem
    {
        public string Id { get; set; }

        public decimal Cost { get; set; }

        public string Name { get; set; }

        public bool IsInsured { get; set; }

        public string ClassifiedId { get; set; }
        
        public decimal InsuredCost { get; set; }

        public ItemStatus Status { get; set; }

        public List<ItemPhoto> Photos { get; set; }

        public List<InsuredPeriod> History { get; set; }
    }
}
