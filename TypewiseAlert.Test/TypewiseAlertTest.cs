using System;
using Xunit;

namespace TypewiseAlert.Test
{
  public class TypewiseAlertTest
  {
    [Fact]
    public void InfersBreachAsPerLimits()
    {
      Assert.True(TypewiseAlert.inferBreach(12, 20, 30) ==
        TypewiseAlert.BreachType.TOO_LOW);
      Assert.True(TypewiseAlert.inferBreach(34, 20, 30) ==
        TypewiseAlert.BreachType.TOO_HIGH);
      Assert.True(TypewiseAlert.inferBreach(25,20,30)==
                  TypewiseAlert.BreachType.NORMAL);
      
    }
    [Fact]
    public void classifyTemperatureBreachAsPerLimits()
    {
      
      Assert.True(TypewiseAlert.classifyTemperatureBreach(TypewiseAlert.CoolingType.PASSIVE_COOLING,20) == 
                  TypewiseAlert.BreachType.NORMAL);
                  
      
    }
  }
}
