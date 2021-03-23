using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        // this is a method. the name of this method is Main
        static void Main(string[] args)
        {
            // goal: get the average grade in a list of grades

            // step 1: create a new list with double type data types and input a starting amount of objects
            List<double> grades = new List<double>() { 12.7, 10.3, 6.11, 4.1 };

            // step 2: add another value to the grades list
            grades.Add(56.1);

            // step 3: initialize the sum and average variables and start at 0.0
            var sumGrades = 0.0;
            var averageGrade = 0.0;

            // step 4: get the number of objects in the grades list and store it in this variable listLength
            var listLength = grades.Count;

            foreach (var grade in grades)
            {
                sumGrades += grade;
                averageGrade = sumGrades / listLength;
            }

            Console.WriteLine($"The average grade is {averageGrade:N1}");
        }
        // end of the method
    }
}
