using Powerplant.API.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Powerplant.API.Services
{
    public interface IPowerCalculationService
    {
        IEnumerable<PerformanceOutputsDto> GetProductionPlanAsync(CalcInputsDto calcInputsDto);
    }
}
