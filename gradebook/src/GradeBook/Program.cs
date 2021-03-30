using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program // this is a class. the name of this class is Program
    {
        static void Main(string[] args) // this is a method. the name of this method is Main
        {
            // use the type Book to add grades to a gradebook, and call that gradebook "Micah's Grade Book"
            // var book = new Book("Micah's Grade Book");
            // book.AddGrade(89.1);
            // book.AddGrade(90.5);
            // book.AddGrade(77.5);
            // end of this practice for now

            // goal: get the average, highest, and lowest grades in a list of grades
            // step 1: create a new list with double type data types and initialize it by inputting a starting amount of values
            var grades = new List<double>() { 12.7, 10.3, 6.11, 4.1 };

            // step 2: add another value to the grades list
            grades.Add(56.1);

            // step 3: initialize the sum and average variables and start at 0.0
            var sumGrades = 0.0;
            var averageGrade = 0.0;
            var highGrade = double.MinValue; // create a new highGrade variable and assign it the lowest number possible in a double type
            var lowGrade = double.MaxValue; // create a new lowGrade variable and assign it the highest number possible in a double type 

            // step 4: get the number of objects in the grades list and store it in this variable listLength
            var listLength = grades.Count;

            // step 5: run through all of the values in the grades list and perform the listed computations
            foreach (var grade in grades)
            {
                highGrade = Math.Max(grade, highGrade); // compare the values (aka grade in this case) in the list of grades to the value of the highGrade variable initialized above and assign the maximum value the highGrade variable

                lowGrade = Math.Min(grade, lowGrade); // similar to what Max does above except looks for the min now

                sumGrades += grade; // the same as sumGrades = sumGrades + grade
                averageGrade = sumGrades / listLength;
            }

            Console.WriteLine($"The highest grade is {highGrade}");
            Console.WriteLine($"The lowest grade is {lowGrade}");
            Console.WriteLine($"The average grade is {averageGrade:N1}"); // N1 only displays up to 1 digit after the averageGrade value 
        }
        // end of the method
    }
}
