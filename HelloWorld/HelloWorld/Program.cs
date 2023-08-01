using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        static double FahrenheitToCelsius(float temperatureFahrenheit)
        {
           double temperatureCelsius = (temperatureFahrenheit - 32) / 1.8;
            return temperatureCelsius;
        }
    }
} 