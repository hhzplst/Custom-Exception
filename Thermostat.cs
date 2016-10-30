namespace CustomException {
  public class Thermostat {
    public double LowerLimit {get; set;}
    public double HigherLimit {get; set;}
    private double temp;
    public double Temp {
      get {
        return temp;
      } 
      set{
        if (value < LowerLimit) throw new TemperatureTooLow("Temperature Too Low!");
        if (value > HigherLimit) throw new TemperatureTooHigh("Temperature Too High!");
        temp = value;
      }
    }
    public Thermostat(double lowerLimit, double higherLimit) {
      LowerLimit = lowerLimit;
      HigherLimit = higherLimit;
    }
  }
}