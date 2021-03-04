using System;

namespace GreaterOrLess
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1, x2, y1, y2, x3, y3, x4, y4;
            Console.WriteLine("Pass The values x1 & y1");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pass The values of x2 & y2");
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pass The values x3 & y3 for Second Line");
            x3 = Convert.ToInt32(Console.ReadLine());
            y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pass The values x4 & y4 for Second Line");
            x4 = Convert.ToInt32(Console.ReadLine());
            y4 = Convert.ToInt32(Console.ReadLine());
            double length1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double length2 = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));
            int diffrence = length1.CompareTo(length2);
            if (diffrence == 0)
                Console.WriteLine("Both Lines are equal in length");
            else if (diffrence > 0)
                Console.WriteLine("First Line is greater than Second Line");
            else
                Console.WriteLine("First Line is smaller than Second Line");
        }
    }
}
