using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyAPI.DTOS
{
    public class MoneyTakerDto
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Department { get; set; }

        
        public decimal Amount { get; set; }

        public DateTime Day { get; set; }

        public bool IsMoneyReceived { get; set; }

        public bool IsMoneySentViaBankTransfer { get; set; }
    }
}
