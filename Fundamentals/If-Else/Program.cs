using System;
// Importing Other Libraries that we may want to use 
//System.console can also be used instead of using it 

namespace IfElse
// To Group and Organize code if we have multiple classes
{
    class Program // Class and ClassName 
    {
        static void Main(string[] args) // 1st Method as the entry method to tell from here it starts
        {
            int a = 5;
            int b = 6;
            if (a + b > 10)
                Console.WriteLine("The answer is greater than the previous one");
            else
                Console.WriteLine("The answer is not greater than the previous one");

            if ((a + b) > 5 || (a - b) < 5)
                Console.WriteLine("The answer is below 5 ");
            else
                Console.WriteLine("The answer is above 5 ");
        }
    }
}

