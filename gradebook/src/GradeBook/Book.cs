using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public void ShowStatistics()
        {
            // goal: get the average, highest, and lowest grades in a list of grades
            // initialize the sum and average variables and start at 0.0
            var sumGrades = 0.0;
            var averageGrade = 0.0;
            var highGrade = double.MinValue; // create a new highGrade variable and assign it the lowest number possible in a double type
            var lowGrade = double.MaxValue; // create a new lowGrade variable and assign it the highest number possible in a double type 

            // get the number of objects in the grades list and store it in this variable listLength
            var listLength = grades.Count;

            // run through all of the values in the grades list and perform the listed computations
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

        private List<double> grades; // this is a field that stores arguments
        private string name; // this is a field that stores arguments in the name field 

    }
}