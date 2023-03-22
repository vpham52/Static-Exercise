namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("What would you like to convert to Celcius?");
            var farenheitInput = int.Parse(Console.ReadLine());

            Console.WriteLine($"{farenheitInput} degrees Fahrenheit is {TempConverter.FahrenheitToCelsius(farenheitInput)} degrees Celcius.");

            Console.WriteLine();

            Console.WriteLine("What would you like to convert to Fahrenheit?");
            var celciustInput = int.Parse(Console.ReadLine());

            Console.WriteLine($"{celciustInput} degrees Celcius is {TempConverter.CelsiusToFahrenheit(celciustInput)} degrees Fahrenheit.");

        }
            
    }
}
