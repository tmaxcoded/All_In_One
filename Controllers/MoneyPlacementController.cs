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
    [Route("api/moneyplacement")]
    [ApiController]
    public class MoneyPlacementController : ControllerBase
    {
        private readonly IUnitOfWork _unitWOrk;
        private readonly IMoneyPlacement _moneyPlacement;
        private readonly IMapper _mapper;

        public MoneyPlacementController(
             IUnitOfWork unitWOrk
            , IMoneyPlacement moneyPlacement, IMapper mapper)
        {
            _unitWOrk = unitWOrk;
            _moneyPlacement = moneyPlacement;
            _mapper = mapper;
        }


        [HttpPost("new")]
        public async Task<IActionResult> Post([FromBody]MoneyPlacementDto placement)
        {
            try
            {
                if (placement == null)
                {
                    return BadRequest(new ResponseDto<object>(StatusCodes.Status400BadRequest.ToString(),
                        MessageStatus.fail, $"object request {nameof(placement)} cannot be empty",
                        null));
                }

                var _mappedPlacement = _mapper.Map<MoneyPlacement>(placement);

                _moneyPlacement.CreateMoneyPlacement(_mappedPlacement);

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
               
               var getAllPlacements = await _moneyPlacement.GetAllMoneyPlacement();

                var _mappedPlacement = _mapper.Map<List<MoneyPlacementDto>>(getAllPlacements);
               

                return StatusCode(StatusCodes.Status200OK,
                    new ResponseDtos<MoneyPlacementDto>(StatusCodes.Status201Created.ToString(),
                    MessageStatus.success, "spooled success",_mappedPlacement));


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
