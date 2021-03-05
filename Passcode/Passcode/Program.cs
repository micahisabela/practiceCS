using System;

namespace Passcode
{
    class Program
    {
        static void Main(string[] args)
        {
            var passcode = "secret";
            var prompt = "What is your password?";

            Console.WriteLine(prompt);
            var userInput = Console.ReadLine();

            if(userInput == passcode)
            {
                Console.WriteLine("Logged in!");
            }
            else
            {
                Console.WriteLine("Try again!");
            }
        }
    }
}
