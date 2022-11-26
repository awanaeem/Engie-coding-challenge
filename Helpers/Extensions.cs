using Powerplant.API.Models;
using System.Collections.Generic;
using System.Linq;

namespace Powerplant.API.Helpers
{
    public static class Extensions
    {
        public static IEnumerable<Variable> OrderPowerplantsByRunningCost(ExternalFactors fuels, List<Variable> powerplants)
        {
            var orderedPowerplants = new List<Variable>();

            foreach (var powerplant in powerplants)
            {
                switch (powerplant.Type)
                {
                    case PowerplantType.gasfired:
                        powerplant.RunningCost = fuels.Gas / powerplant.Efficiency;
                        break;
                    case PowerplantType.turbojet:
                        powerplant.RunningCost = fuels.Kerosine / powerplant.Efficiency;
                        break;
                    case PowerplantType.windturbine:
                        powerplant.RunningCost = 0;
                        break;
                    default:
                        break;
                }

                orderedPowerplants.Add(powerplant);
            }

            return orderedPowerplants.OrderBy(c => c.RunningCost);
        }
    }
}
