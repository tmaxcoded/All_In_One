using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyAPI.models
{
    public class MoneyPlacement
    {
        public long Id { get; set; }

        [RegularExpression(@"^\d+\.\d{0,2}$")]
        [Range(0, 9999999999999999.99)]
        public decimal Amount { get; set; }

        public DateTime DatePlaced { get; set; }

        public string PlacedByWhom { get; set; }
    }
}
