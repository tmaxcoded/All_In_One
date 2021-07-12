using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyAPI.models
{
    public class MoneyTaker
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Department { get; set; }

        [RegularExpression(@"^\d+\.\d{0,2}$")]
        [Range(0, 9999999999999999.99)]
        public decimal Amount { get; set; }

        public DateTime Day { get; set; }

        public bool IsMoneyReceived { get; set; }

        public bool IsMoneySentViaBankTransfer { get; set; }
    }
}
