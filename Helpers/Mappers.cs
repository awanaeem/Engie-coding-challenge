using Powerplant.API.Dtos;
using Powerplant.API.Models;
using System.Collections.Generic;
using System.Linq;

namespace Powerplant.API.Helpers
{
    public static class Mappers
    {
        public static CalcInputsDto ToDto(this CalcInputs src)
        {
            return src == null ? null : new CalcInputsDto()
            {
                Load = src.Load,
                Fuels = src.Fuels.ToDto(),
                Powerplants = src.Powerplants?.ToDto(),
            };
        }

        public static CalcInputs FromDto(this CalcInputsDto src)
        {
            return src == null ? null : new CalcInputs()
            {
                Load = src.Load,
                Fuels = src.Fuels.FromDto(),
                Powerplants = src.Powerplants?.FromDto(),
            };
        }

        public static VariableDto ToDto(this Variable src)
        {
            return src == null ? null : new VariableDto()
            {
                Name = src.Name,
                Type = src.Type,
                Efficiency = src.Efficiency,
                PMax = src.PMax,
                PMin = src.PMin,
            };
        }

        public static Variable FromDto(this VariableDto src)
        {
            return src == null ? null : new Variable()
            {
                Name = src.Name,
                Type = src.Type,
                Efficiency = src.Efficiency,
                PMax = src.PMax,
                PMin = src.PMin,
            };
        }

        public static List<VariableDto> ToDto(this List<Variable> src)
        {
            return src?.Select(f => f.ToDto()).ToList();
        }

        public static List<Variable> FromDto(this List<VariableDto> src)
        {
            return src == null ? null : new List<Variable>(src?.Select(f => f.FromDto()));
        }

        public static ExternalFactorsDto ToDto(this ExternalFactors src)
        {
            return src == null ? null : new ExternalFactorsDto()
            {
                Gas = src.Gas,
                Kerosine = src.Kerosine,
                Co2 = src.Co2,
                Wind = src.Wind,
            };
        }

        public static ExternalFactors FromDto(this ExternalFactorsDto src)
        {
            return src == null ? null : new ExternalFactors()
            {
                Gas = src.Gas,
                Kerosine = src.Kerosine,
                Co2 = src.Co2,
                Wind = src.Wind,
            };
        }
    }
}
