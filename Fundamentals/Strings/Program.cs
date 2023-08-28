﻿namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {

            string employee = "Maria";
            string manager = "Robert";
            Console.WriteLine($"{manager} is the manager of {employee}");


            // Prints the number of characters present in a string variable
            Console.WriteLine($"The manager {manager} has {manager.Length} letters");
            Console.WriteLine($"The employee {employee} has {employee.Length} letters");

            // String  companyName 
            string companyName = "    Google    ";
            Console.WriteLine($"[{companyName}]");

            //Trim at the beginning of the string 
            string modifiedCompanyName = companyName.TrimStart();
            Console.WriteLine($"[{modifiedCompanyName}]");

            //Trim at the end of the string 
            modifiedCompanyName = companyName.TrimEnd();
            Console.WriteLine($"[{modifiedCompanyName}]");

            //Trim the entire string 
            modifiedCompanyName = companyName.Trim();
            Console.WriteLine($"[{modifiedCompanyName}]");

            //Normal String print
            string sayHi = "Hi Richa";
            Console.WriteLine($"{sayHi}");

            //Replacing the existing string and printing it 
            sayHi = sayHi.Replace("Hi", "Greetings");
            Console.WriteLine($"{sayHi}");

            // Convert strings to Upper and lower cases 
            Console.WriteLine(sayHi.ToUpper());
            Console.WriteLine(sayHi.ToLower());

            //Searches whether the given string exists in the variable or not 
            string lyrics = "All the money you made , Will never buy back your soul…";
            Console.WriteLine(lyrics.Contains("money"));
            Console.WriteLine(lyrics.Contains("park"));

            // Searches whether the sentence in the variable starts with the given string or not
            Console.WriteLine(lyrics.StartsWith("All"));
        }
    }
}
