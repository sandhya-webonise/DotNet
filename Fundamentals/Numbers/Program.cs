namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 5;
            //Addition of numbers
            int c = a + b;
            Console.WriteLine(c); // c = 15;
            //Substraction of numbers
            int d = a - b;
            Console.WriteLine(d);
            //Multiplication of numbers
            int e = a * b;
            Console.WriteLine(e);
            //Division of numbers
            int f = a / b;
            Console.WriteLine(f);
            //Order of operations 
            int g = a + b * c; // (10 + 5 * 15) = 85 
            Console.WriteLine(g); // 85 
            int h = (a + b) * c; // (10 + 5 * 15) = 85 
            Console.WriteLine(h); // 85 
            int i = (a + b) - 5 * c + (10 * 3) / 5 + 5;
            Console.WriteLine(i); // Brackets are considered as high priority

            int j = (a + b) / c;
            Console.WriteLine($"quotient: {j}");

            int k = (a + b) % c;
            Console.WriteLine($"remainder: {k}");

            // integer numbers 
            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of numbers is from {min} to {max}");

            //double precision numbers 
            double max1 = double.MaxValue;
            double min1 = double.MinValue;
            Console.WriteLine($"The range of double precision numbers is from {min1} to {max1}");

            //decimal numbers 
            decimal max2 = decimal.MaxValue;
            decimal min2 = decimal.MinValue;
            Console.WriteLine($"The range of decimal numbers is from {min2} to {max2}");

            //long numbers
            long max3 = long.MaxValue;
            long min3 = long.MinValue;
            Console.WriteLine($"The range of long numbers is from {min3} to {max3}");

            //short numbers
            short max4 = short.MaxValue;
            short min4 = short.MinValue;
            Console.WriteLine($"The range of short numbers is from {min4} to {max4}");

            // Challenge to calculate area of a circle with radius 5
            double radius = 5;
            double area = Math.PI * radius * radius;
            Console.WriteLine(area);
        }
    }
}
