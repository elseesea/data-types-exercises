using System;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            const String alice = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            Console.WriteLine("Enter search string");
            String userInput = Console.ReadLine();
            int resultIndex = alice.IndexOf(userInput.ToLower());
            if (resultIndex>0)
            {
                Console.WriteLine("Found at index = " + resultIndex + " and length = " + userInput.Length);
                Console.WriteLine(alice.Substring(0, resultIndex) + alice.Substring(resultIndex + userInput.Length));
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }
    }
}
