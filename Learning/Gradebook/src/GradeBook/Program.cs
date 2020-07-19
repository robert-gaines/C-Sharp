using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine($"Argument array length is: {args.Length}");
            Console.WriteLine($"Hello: {args[0]}");
            Console.WriteLine("This is a C# string!");

            if(args.Length > 0)
            {
                Console.WriteLine("[*] Console Arguments Length > 0");    
            }
            else
            {
                Console.WriteLine("[*] Console Arguments Array Length is 0");
            }
            */

            /*
            Basic Data Types and Arithmetic Operations
            ------------------------------------------
            */

            /*
            double x = 31.4;
            double y = 72.1;

            double sum = x+y;
     
            Console.WriteLine($"Sum is: {sum}");
            */

            /*
                Array Basics
            */

            Console.WriteLine("[*] Welcome to the Gradebook Application [*]");

            var book = new Book("Test");

            book.PopulateBook();

            book.DisplayBook();

            double max_value;
            double min_value;
            double book_avg;

            max_value = book.FindMax();
            min_value = book.FindMin();

            book_avg = book.FindAverage();

            System.Console.WriteLine("[*] Max Value: "+max_value);
            System.Console.WriteLine("[*] Min Value: "+min_value);

            System.Console.WriteLine("[*] Book Average: "+book_avg);

            // var values = new double[100];

            // var rand_value = new Random();

            // System.Console.WriteLine(rand_value.Next(100));

            // var values_length = values.Length;

            // for(int i = 0;i < values_length; i++)
            // {
            //     var random_entry = rand_value.Next(100);
            //     System.Console.WriteLine($"[+] Adding: {random_entry}");
            //     values[i] += random_entry;
            // }

            // double sum = 0;

            // for(int j = 0; j < values_length; j++)
            // {
            //     sum += values[j];
            // }

            // System.Console.WriteLine($"[*] Sum of the values array is: {sum}");

            // double average = sum / values.Length;

            // System.Console.WriteLine($"[*] Average of elements in the values array is: {average}");

            // var alt_values = new List<double>();

            // int k = 100; int l = 0;
            // var rand_alt = new Random();
            // while(l < k)
            // {
            //     alt_values.Add(rand_alt.Next(100));
            //     l++;
            // }

            // double list_sum = 0;

            // foreach(double value in alt_values)
            // {
            //     System.Console.WriteLine($"[*] Values List Element: {value}");
            //     list_sum += value;
            // }

            // double list_length = alt_values.Count;
            // System.Console.WriteLine($"[*] List length is: {list_length} ");
            // System.Console.WriteLine($"[*] Sum of list values is: {list_sum}");
            // double list_average = list_sum / list_length;
            // System.Console.WriteLine($"[*] Average of list values is: {list_average:N3} ");
   
        }
    }
}

