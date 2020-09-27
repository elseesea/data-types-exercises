using System;

namespace input_output
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            //Console.WriteLine("Hello World!");
            Console.WriteLine("Hello " + name);
        }
    }
}
