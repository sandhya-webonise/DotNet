using System;
// Importing Other Libraries that we may want to use 
//System.console can also be used instead of using it 
using System.Collections.Generic;
// To import the List methods
namespace Arrays // To Group and Organize code if we have multiple classes
{
    class Program
    {
        static void Main(string[] args) // 1st Method as the entry method to tell from here it starts
        {
            var employees = new List<string> { "Andrew", "Sandhya", "Mounika", "Komathi" };
            //The below foreach can also be written using for loop given below 
            foreach (string employee in employees)
            {
                Console.WriteLine($"Hello {employee.ToUpper()}!");
            }
            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine($"Hello {employees[i].ToUpper()}!");
            }
            // add or remove the employees in the List 
            employees.Add("Abhay");
            employees.Add("Rahul");
            employees.Remove("Rahul");
            foreach (string employee in employees)
            {
                Console.WriteLine(employee);
            }
            Console.WriteLine(employees[1]);
            // Search the INDEX OF THE NAME 
            var index = employees.IndexOf("Sandhya");
            if (index == -1)
            {
                Console.WriteLine("Item Not Found or Doesn't exist in List");
            }
            else
            {
                Console.WriteLine($"The name {employees[index]} is at index {index}");
            }

            // Sort the List 
            employees.Sort();
            foreach (string employee in employees)
            {
                Console.WriteLine(employee);
            }
            // Prints the fibonaci numbers 
            {
                var fibonaci = new List<int> { 1, 1, 2 };
                var preval = fibonaci[fibonaci.Count - 1];
                var preval2 = fibonaci[fibonaci.Count - 2];
                fibonaci.Add(preval + preval2);
                foreach (var number in fibonaci)
                {
                    Console.WriteLine(number);
                }
            }
            // Challenge to print the fibonaci numbers from 1 to 20 

            {
                var fibonaciNumbers = new List<int> { 1, 1 };
                while (fibonaciNumbers.Count < 20)
                {
                    var a = fibonaciNumbers[fibonaciNumbers.Count - 1];
                    var b = fibonaciNumbers[fibonaciNumbers.Count - 2];
                    fibonaciNumbers.Add(a + b);
                }
                foreach (var num in fibonaciNumbers)
                {
                    Console.WriteLine(num);
                }
            }

        }
    }
}
