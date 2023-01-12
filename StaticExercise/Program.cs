namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is the temperature in F you want to convert?");
            var fahTemp = Convert.ToDouble(Console.ReadLine()); 
            var convertToCel = TempConverter.FahrenheitToCelsius(fahTemp);

            Console.WriteLine($"that equals {convertToCel} degress Celsius");
            Console.WriteLine();

            Console.WriteLine("what is temperature in C you want to convert?");
            var celTemp = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"That equals {TempConverter.CelsiusToFahrenheit(celTemp)} degrees F");
        }
    }
}
