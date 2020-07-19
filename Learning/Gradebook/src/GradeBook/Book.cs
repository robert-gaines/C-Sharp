using System.Collections.Generic;
using System;

namespace GradeBook
{
    class Book
    {
        public Book(string name)
        {
            /* This is a constructor! */
            grades = new List<double>();
            this.name = name;
        }
        public void AddGrade(double gradeEntry)
        {
            grades.Add(gradeEntry);
        }

        private List<double> grades;
        private string name;
    }
}