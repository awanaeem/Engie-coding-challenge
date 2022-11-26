using System.Collections.Generic;

namespace Powerplant.API.Models
{
    public class CalcInputs
    {
        public int Load { get; set; }
        public ExternalFactors Fuels { get; set; }
        public List<Variable> Powerplants { get; set; }
    }
}
