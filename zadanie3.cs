using System;

class Program
{
    static void Main()
    {
        double temperaturaCelsjusz = 25;
        double temperaturaFahrenheit = temperaturaCelsjusz * 9 / 5 + 32;
        double konwersjaCelsjusz = (temperaturaFahrenheit - 32) * 5 / 9;

        Console.WriteLine("Temperatura w Celsjuszach: " + temperaturaCelsjusz.ToString("F2"));
        Console.WriteLine("Temperatura w Fahrenheitach: " + temperaturaFahrenheit.ToString("F2"));
        Console.WriteLine("Po konwersji z powrotem: " + konwersjaCelsjusz.ToString("F2"));

        if (temperaturaCelsjusz < 0)
        {
            Console.WriteLine("Uwaga: temperatura poniżej zera!");
        }
    }
}
