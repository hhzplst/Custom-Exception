using System;

namespace CustomException {
  public class TemperatureOutOfRange : Exception {
    public TemperatureOutOfRange() : base(){}
    public TemperatureOutOfRange(string msg) : base(msg){}
  }
}