namespace CustomException {
  public class TemperatureTooLow : TemperatureOutOfRange {
    public TemperatureTooLow() : base(){}
    public TemperatureTooLow(string msg) : base(msg){}
  }
}