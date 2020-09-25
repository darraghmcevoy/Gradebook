﻿using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Scott's Grade Book ");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.grades.Add(77.5);
            var stats = book.GetStatistics();
            
            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"the highest grade is {stats.High}");
            Console.WriteLine($"The average grade is {stats.Average:N1}");
        }   
    }
}
