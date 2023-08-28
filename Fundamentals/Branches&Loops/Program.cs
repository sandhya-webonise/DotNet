using System;
namespace BranchesAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //While loop
            int a = 6;
            int b = 10;
            while (a < b)
            {
                Console.WriteLine($"{a} is smaller than {b}");
                a++;
            }
            // Do - While loop
            int c = 5;
            do
            {
                Console.WriteLine($"I am {c}");
                c++;
            }
            while (c < 10);

            // For loop
            for (int d = 0; d < 5; d++)
            {
                Console.WriteLine($"Index of d is  {d}");
            }
            while (c < 10) ;
            // Challenge Sum of integers which are divisible by 3
            int total = 0;
            int firstNumber = 1;
            while (firstNumber <= 20)
            {
                if (firstNumber % 3 == 0)
                {
                    total += firstNumber;
                }
                firstNumber++;
            }
            Console.WriteLine($"The sum of numbers is {total}");
        }
    }
}
