using System;
namespace StaticExercise
{
	public static class TempConverter
	{
        public static double FahrenheitToCelsius(double fNum)
        {
            var fahrenheit = (fNum - 32) * (5d / 9d);

            return fahrenheit;


        }

        public static  double CelsiusToFahrenheit(double cNum)
        {
            var celcius = cNum * (9d/5d) + 32;
            return celcius; 

        }


    }
}

