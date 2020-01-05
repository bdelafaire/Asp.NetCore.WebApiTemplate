using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCore.WebApi.Domain.Models
{
    public enum EUnitOfMeasurement : byte
    {
        [Description("UN")]
        Unity = 1,
        [Description("MG")]
        Milligram = 1,
        [Description("G")]
        Gram = 1,
        [Description("KG")]
        Kilogram = 1,
        [Description("L")]
        Litter = 1,
    }
}
