using System;
using System.Collections.Generic;

namespace GradeBook 
{
    class Book 
    {
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        List<double> grades; // however, this will throw an error without initializing it. 
    }
}