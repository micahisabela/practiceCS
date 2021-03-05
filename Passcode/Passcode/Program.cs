using System;

namespace Passcode
{
    class Program
    {
        static void Main(string[] args)
        {
            var passcode = "";

            while (passcode != "secret")
            {
                Console.WriteLine("What is the passcode?");
                passcode = Console.ReadLine();

                if (passcode != "secret")
                {
                    Console.WriteLine("Try again!");
                }
            }
            Console.WriteLine("Logged in!");
        }
    }
}
