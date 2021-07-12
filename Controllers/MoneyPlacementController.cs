using HealthyAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyAPI.Controllers
{
    [Route("api/moneyplacement")]
    [ApiController]
    public class MoneyPlacementController : ControllerBase
    {
        private readonly IMoneyPlacement _moneyPlacement;

        public MoneyPlacementController(IMoneyPlacement moneyPlacement)
        {
            _moneyPlacement = moneyPlacement;
        }



        public Task<IActionResult> Post()
    }
}
