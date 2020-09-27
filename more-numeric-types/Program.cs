using System;

namespace more_numeric_types
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Miles driven");
            String userInput = Console.ReadLine();
            float miles = float.Parse(userInput);
            Console.WriteLine("Gallons used");
            userInput = Console.ReadLine();
            float gallons = float.Parse(userInput);
            Console.WriteLine("Miles per gallon is " + miles / gallons);
        }
    }
}
