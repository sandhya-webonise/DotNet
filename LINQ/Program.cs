//LINQ IS LANGUANGE INTEGRATED QUERY 

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print the numbers less than 5 using LINQ 
            // int[] numbers = { 1, 2, 4, 6, 10, 3, 45, 5 };
            List<int> numbers = new List<int>() { 1, 2, 4, 6, 10, 3, 45, 5 };

            var result = from num in numbers
                         where num < 5
                         select num;

            Console.WriteLine("numbers less than 5 are: ");
            foreach (var num in result)
            {
                Console.WriteLine(num);
            }

            // Print digits whose name is shorter than its value 
            string[] digits = { "one", "two", "three", "four", "five", "six", "seven" };
            var shortDigits = digits.Where((digit, index) => digit.Length < index);
            Console.WriteLine("Short Digits in the string Array are");
            foreach (var d in shortDigits)
            {
                Console.WriteLine($"{d} is shorter than its index value");
            }

            // Print the first 5 numbers using LINQ from the array 
            int[] values = { 1, 2, 4, 6, 10, 3, 45, 5 };

            var firstfewNumbers = values.Take(5);

            Console.WriteLine("First 5 numbers in the array are: ");
            foreach (var n in firstfewNumbers)
            {
                Console.WriteLine(n);
            }

            // Print the numbers which are less than 10 from first to until the condition is false in array using LINQ from the array 
            int[] abc = { 1, 2, 45, 6, 10, 3, 5 };

            var firstNumbers = abc.TakeWhile(a => a < 10);

            Console.WriteLine("First few numbers in the array which are less than 10 are: ");
            foreach (var i in firstNumbers)
            {
                Console.WriteLine(i);
            }

            // Compare two sequences for equality 
            var a = new string[] { "a", "b", "c" };
            var b = new string[] { "b", "c", "a" };
            bool output = a.SequenceEqual(b);
            Console.WriteLine($"Sequences match: {output}"); // gives output as false since the sequence of strings doesn't match in variables a & b 

            // Combine the sequences using zip 
            int[] c = { 0, 2, 4, 6, 8 };
            int[] g = { 1, 3, 5, 7, 9 };
            int e = c.Zip(g, (a, b) => a * b).Sum();
            Console.WriteLine($"Zipped Result: {e}");

            // Select from multiple sequences 
            int[] num1 = { 1, 3, 5, 7 };
            int[] num2 = { 0, 2, 4, 6 };
            var res = from m in num1
                      from n in num2
                      where m < n
                      select (m, n);
            Console.WriteLine("Numbers which are less than a < b:");
            foreach (var num in res)
            {
                Console.WriteLine($"{num.m} is less than {num.n}");
            }

            //Reuse queries with new results 

            //Defered Execution lets us define a query once 
            //and then reuse it later after the data changes 
            int[] nums = { 5, 4, 3, 2, 1, 0, 9, 8, 7, 6 };
            var lowestNumbers = from n in nums
                                where n <= 3
                                select n;

            Console.WriteLine("Numbers less than 3 are");
            foreach (int n in lowestNumbers)
            {
                Console.WriteLine(n);
            }
            for (int i = 0; i < 10; i++)
            {
                nums[i] = -nums[i];
            }
            // In the below execution the same query will execute for the result of lowestNumbers
            Console.WriteLine("Second Execution Numbers less than 3");
            foreach (int n in lowestNumbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}
