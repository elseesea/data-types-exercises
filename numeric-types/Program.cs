using System;

namespace numeric_types
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input length of rectange");
            string userInput = Console.ReadLine();
            double lenRec = double.Parse(userInput);
            Console.WriteLine("Input width of rectange");
            userInput = Console.ReadLine();
            double widthRec = double.Parse(userInput);
            double areaRec = lenRec * widthRec;
            Console.WriteLine("Area of rectangle is " + areaRec);            
        }
    }
}
