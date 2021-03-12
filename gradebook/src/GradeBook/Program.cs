using System;

namespace GradeBook
{
    class Program
    {
        // this is a method. the name of this method is Main
        static void Main(string[] args)
        {
            // goal: pass my name as a parameter

            if (args.Length > 0)
            {
                Console.WriteLine($"Hello {args[0]}!");
            }
            else
            {
                Console.WriteLine("Hello");
            }
        }
        // end of the method
    }
}
