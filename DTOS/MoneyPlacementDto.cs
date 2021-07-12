using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyAPI.DTOS
{
    public class MoneyPlacementDto
    {
        public long Id { get; set; }

        
        public decimal Amount { get; set; }

        public DateTime DatePlaced { get; set; }

        public string PlacedByWhom { get; set; }
    }
}
