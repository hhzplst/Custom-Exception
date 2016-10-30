using System;

namespace CustomException {
  public class ThermostatTest {
    public static void Main(string[] args) {
      Thermostat t = new Thermostat(0, 100);
      try {
        t.Temp = 150;
      } catch (TemperatureTooHigh e1) {
        Console.WriteLine(e1.Message);
      } 

      try {
        t.Temp = -50;
      } catch (TemperatureOutOfRange e) {
        Console.WriteLine("Super class caught me");
        Console.WriteLine(e.Message);
      }
    }
  }
}

/***********************************TEST OUTPUT****************************************

Temperature Too High!
Super class caught me
Temperature Too Low!

**********************************END TEST OUTPUT*************************************/