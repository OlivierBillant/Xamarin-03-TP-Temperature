using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin_03_Temp.Util
{
public class TemperatureConverter
{
    public static String FahrenheitFromCelcius(Double celsius)
    {
        double fahrenheit = ((9.0 / 5.0) * celsius + 32.0);
        return fahrenheit.ToString();
    }
    public static String CelciusFromFahrenheit(Double fahrenheit)
    {
        double celsius = (5.0 / 9.0) * (fahrenheit - 32.0);
        return celsius.ToString();
    }
}
}