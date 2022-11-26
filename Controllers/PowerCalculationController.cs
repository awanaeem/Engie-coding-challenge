using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Powerplant.API.Dtos;
using Powerplant.API.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Powerplant.API.Controllers
{
    /// <summary>
    ///  productionplan endpoint that provides all calculations.
    /// </summary>
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class PowerCalculationController : ControllerBase
    {
        private IPowerCalculationService PowerCalculationService;

        public PowerCalculationController(IPowerCalculationService powerCalculationService)
        {
            PowerCalculationService = powerCalculationService;
        }

        /// <summary>
        /// Calculates the power for the provided calculation inputs.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <param name="calcInputsDto">Inputs to be used for power calculation.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("productionplan")]
        public IActionResult GetProductionPlanAsync(CalcInputsDto calcInputsDto)
        {
            try
            {
                var outputs = PowerCalculationService.GetProductionPlanAsync(calcInputsDto);
                return Ok(outputs);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
