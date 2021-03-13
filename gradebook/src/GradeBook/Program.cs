using System;

namespace GradeBook
{
    class Program
    {
        // this is a method. the name of this method is Main
        static void Main(string[] args)
        {
            var grades = new double[3];
            grades[0] = 12.7;
            grades[1] = 34.5;
            grades[2] = 77.9;

            Console.WriteLine(grades[0] + grades[1] + grades[2]);

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
