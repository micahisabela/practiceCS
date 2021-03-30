using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program // this is a class. the name of this class is Program
    {
        static void Main(string[] args) // this is a method. the name of this method is Main
        {
            var book = new Book("Micah's Grade Book"); // use the type Book to add grades to a gradebook, and call that gradebook "Micah's Grade Book"
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);
            book.ShowStatistics();
        }
        // end of the method
    }
}
