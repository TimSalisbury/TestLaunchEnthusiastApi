using System.ComponentModel;

namespace TestAPI.Domain.Models
{
    public enum EUnitOfMeasurement
    {
        [Description("Kilonewtons")]
        kN,
        
        [Description("Kilogram")]
        kg,
        
        [Description("Meter")]
        m
    }
}