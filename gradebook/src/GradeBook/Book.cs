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

        private List<double> grades; // this is a field that stores arguments
        private string name; // this is a field that stores arguments in the name field 

    }
}