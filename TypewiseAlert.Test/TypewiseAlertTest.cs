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
      TypewiseAlert.checkAndAlert(
        TO_CONTROLLER, BatteryChar.CoolingType, 0);
    
    }
  }
}
