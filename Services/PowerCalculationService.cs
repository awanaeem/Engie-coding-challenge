using Powerplant.API.Dtos;
using Powerplant.API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Powerplant.API.Helpers;
using System;
using Microsoft.Extensions.Logging;

namespace Powerplant.API.Services
{
    public class PowerCalculationService : IPowerCalculationService
    {
        private readonly ILogger _logger;

        public PowerCalculationService(ILogger<PowerCalculationService> logger)
        {
            this._logger = logger;
        }
        public IEnumerable<PerformanceOutputsDto> GetProductionPlanAsync(CalcInputsDto calcInputsDto)
        {
            try
            {
                List<PerformanceOutputsDto> outputs = new List<PerformanceOutputsDto>();

                var calcInputs = calcInputsDto.FromDto();

                var preferredPowerPlants = Extensions.OrderPowerplantsByRunningCost(calcInputs.Fuels, calcInputs.Powerplants);

                foreach (var preferredPowerPlant in preferredPowerPlants)
                {
                    if (preferredPowerPlant != null)
                    {
                        if (calcInputs.Load >= preferredPowerPlant.PMin && calcInputs.Load <= preferredPowerPlant.PMax)
                        {
                            outputs.Add(new PerformanceOutputsDto { Name = preferredPowerPlant.Name, Power = calcInputs.Load });
                        }
                        else if (calcInputs.Load > preferredPowerPlant.PMax)
                        {
                            outputs.Add(new PerformanceOutputsDto { Name = preferredPowerPlant.Name, Power = preferredPowerPlant.PMax });
                        }
                        else
                        {
                            outputs.Add(new PerformanceOutputsDto { Name = preferredPowerPlant.Name, Power = 0 });
                        }
                    }
                }

                return outputs;

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);

                return null;
            }
        }
    }
}
