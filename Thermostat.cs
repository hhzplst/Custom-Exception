namespace CustomException {
  public class Thermostat {
    public double LowerLimit {get; set;}
    public double HigherLimit {get; set;}
    public double Temp {
      get {
        return Temp;
      } 
      set{
        if (value < LowerLimit) throw new TemperatureTooLow();
        if (value > HigherLimit) throw new TemperatureTooHigh();
        Temp = value;
      }
    }
    public Thermostat(double lowerLimit, double higherLimit) {
      LowerLimit = lowerLimit;
      HigherLimit = higherLimit;
    }
  }
}