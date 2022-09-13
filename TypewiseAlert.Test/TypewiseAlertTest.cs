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
     Assert.True(TypewiseAlert.classifyTemperatureBreach(TypewiseAlert.CoolingType.HI_ACTIVE_COOLING,35) == 
                  TypewiseAlert.BreachType.NORMAL);
      Assert.True(TypewiseAlert.classifyTemperatureBreach(TypewiseAlert.CoolingType.MED_ACTIVE_COOLING,37) == 
                  TypewiseAlert.BreachType.NORMAL);
      Assert.True(TypewiseAlert.classifyTemperatureBreach(TypewiseAlert.CoolingType.PASSIVE_COOLING,50) == 
                  TypewiseAlert.BreachType.TOO_HIGH);
     Assert.True(TypewiseAlert.classifyTemperatureBreach(TypewiseAlert.CoolingType.HI_ACTIVE_COOLING,50) == 
                  TypewiseAlert.BreachType.TOO_HIGH);
      Assert.True(TypewiseAlert.classifyTemperatureBreach(TypewiseAlert.CoolingType.MED_ACTIVE_COOLING,50) == 
                  TypewiseAlert.BreachType.TOO_HIGH);
      Assert.True(TypewiseAlert.classifyTemperatureBreach(TypewiseAlert.CoolingType.PASSIVE_COOLING,-5) == 
                  TypewiseAlert.BreachType.TOO_LOW);
     Assert.True(TypewiseAlert.classifyTemperatureBreach(TypewiseAlert.CoolingType.HI_ACTIVE_COOLING,-15) == 
                  TypewiseAlert.BreachType.TOO_LOW);
      Assert.True(TypewiseAlert.classifyTemperatureBreach(TypewiseAlert.CoolingType.MED_ACTIVE_COOLING,-25) == 
                  TypewiseAlert.BreachType.TOO_LOW);
    }
    [Fact]
    public void checkAndAlertAsPerLimits()
    {
      //TypewiseAlert.BatteryCharacter bc = new TypewiseAlert.BatteryCharacter();
      //bc.coolingType=TypewiseAlert.CoolingType.MED_ACTIVE_COOLING;
      //bc.brand="abcd";
      //Assert.True(TypewiseAlert.checkAndAlert(TypewiseAlert.AlertTarget.TO_CONTROLLER,bc,20)==typeof(void));
    }
  }
}
