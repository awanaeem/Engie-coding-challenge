using Powerplant.API.Helpers;

namespace Powerplant.API.Dtos
{
    public class VariableDto
    {
        public string Name { get; set; }

        public PowerplantType Type { get; set; }

        public double Efficiency { get; set; }

        public int PMin { get; set; }

        public int PMax { get; set; }

        public double RunningCost { get; set; }
    }
}
