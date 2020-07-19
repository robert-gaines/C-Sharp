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

        public void PopulateBook()
        {
            var rand_value = new Random();

            for(int i = 0; i <= 10; i++)
            {
                var random_entry = rand_value.Next(100);
                grades.Add(random_entry);
            }
        }

        public void DisplayBook()
        {
            System.Console.WriteLine("[*] Displaying grades...");
            foreach(double grade in grades)
            {
                System.Console.WriteLine(grade);
            }
        }
        public double FindMin()
        {
            double min_value = grades[0];
            foreach(double grade in grades)
            {
                if(grade < min_value)
                {
                    min_value = grade;
                }
            }
            return min_value;
        }
        public double FindMax()
        {   
            double max_value = 0;
            foreach(double grade in grades)
            {
                if(grade > max_value)
                {
                    max_value = grade;
                }    
            }
            return max_value;
        }

        public double FindAverage()
        {
            double sum = 0;
            double avg = 0;

            foreach(double grade in grades)
            {
                sum += grade;
            }

            avg = sum/grades.Count;

            return avg;
        }
        public void AddGrade(double gradeEntry)
        {
            grades.Add(gradeEntry);
        }
        private List<double> grades;
        private string name;
    }
}