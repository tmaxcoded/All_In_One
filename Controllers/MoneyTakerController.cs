using HealthyAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyAPI.Controllers
{
    [Route("api/moneytaker")]
    [ApiController]
    public class MoneyTakerController : ControllerBase
    {
        private readonly IMoneyPlacement _moneyTaker;

        public MoneyTakerController(IMoneyPlacement moneyTaker)
        {
            _moneyTaker = moneyTaker;
        }
    }
}
