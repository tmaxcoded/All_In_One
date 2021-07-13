using AutoMapper;
using HealthyAPI.DTOS;
using HealthyAPI.models;
using HealthyAPI.Repositories;
using HealthyAPI.Services;
using HealthyAPI.utilities;
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
        private readonly IUnitOfWork _unitWOrk;
        private readonly IMoneyTaker _moneyTaker;
        private readonly IMapper _mapper;

        public MoneyTakerController(
             IUnitOfWork unitWOrk
            , IMoneyTaker moneyTaker, IMapper mapper)
        {
            _unitWOrk = unitWOrk;
            _moneyTaker = moneyTaker;
            _mapper = mapper;
        }


        [HttpPost("new")]
        public async Task<IActionResult> Post([FromBody] MoneyTakerDto moneytaker)
        {
            try
            {
                if (moneytaker == null)
                {
                    return BadRequest(new ResponseDto<object>(StatusCodes.Status400BadRequest.ToString(),
                        MessageStatus.fail, $"object request {nameof(moneytaker)} cannot be empty",
                        null));
                }

                var _mappedTaker = _mapper.Map<MoneyTaker>(moneytaker);

                _moneyTaker.CreateMoneyTaker(_mappedTaker);

                await _unitWOrk.SavechangesAsync();

                return StatusCode(StatusCodes.Status201Created,
                    new ResponseDto<object>(StatusCodes.Status201Created.ToString(),
                    MessageStatus.success, "created success"));


            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                    new ResponseDto<object>(StatusCodes.Status500InternalServerError.ToString(),
                   MessageStatus.fail, ex.Message));
            }

        }

        [HttpPost("")]
        public async Task<IActionResult> Get()
        {
            try
            {

                var getAllPlacements = await _moneyTaker.GetAllMoneyTakers();

                var _mappedPlacement = _mapper.Map<List<MoneyTakerDto>>(getAllPlacements);


                return StatusCode(StatusCodes.Status200OK,
                    new ResponseDtos<MoneyTakerDto>(StatusCodes.Status201Created.ToString(),
                    MessageStatus.success, "spooled success", _mappedPlacement));


            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                    new ResponseDto<object>(StatusCodes.Status500InternalServerError.ToString(),
                   MessageStatus.fail, ex.Message));
            }

        }
    }
}
