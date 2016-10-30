namespace CustomException {
  public class TemperatureTooHigh : TemperatureOutOfRange {
    public TemperatureTooHigh() : base(){}
    public TemperatureTooHigh(string msg) : base(msg){}
  }
}