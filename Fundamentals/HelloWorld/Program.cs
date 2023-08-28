﻿namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prints the string Hello, World! on the Terminal 
            Console.WriteLine("Hello, World!");

            // With Name 
            string name = "John";
            Console.WriteLine(name);

            //With String concatenation 
            string person = "Robert";
            Console.WriteLine("Hello " + person);

            //With String Interpolation 
            string employee = "Joe";
            Console.WriteLine($"Hello {employee}");
        }
    }
}
