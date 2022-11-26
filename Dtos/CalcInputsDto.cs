using Powerplant.API.Models;
using System.Collections.Generic;

namespace Powerplant.API.Dtos
{
    public class CalcInputsDto
    {
        public int Load { get; set; }
        public ExternalFactorsDto Fuels { get; set; }
        public List<VariableDto> Powerplants { get; set; }
    }
}
