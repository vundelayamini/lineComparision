using System;

namespace LineComparision
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1, x2, y1, y2, x3, y3, x4, y4;
            Console.WriteLine("Enter values for x1 & y1");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter values for x2 & y2");
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter values for x3 & y3 for Line 2");
            x3 = Convert.ToInt32(Console.ReadLine());
            y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter values for x4 & y4 for Line 2");
            x4 = Convert.ToInt32(Console.ReadLine());
            y4 = Convert.ToInt32(Console.ReadLine());
            double line1 = (Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2));
            double line2 = (Math.Sqrt((x4 - x3) ^ 2 + (y4 - y3) ^ 2));
            int variation = line1.CompareTo(line2);
            Boolean difference2 = line1.Equals(line2);
            if (difference2 == true)
                Console.WriteLine("Both Lines are equal in length");
            else
                Console.WriteLine("Both are not equal in length");

            if (difference == 0)
                Console.WriteLine("Both Lines are equal in length");
            else if (difference > 0)
                Console.WriteLine("First Line is greater than Second Line");
            else
                Console.WriteLine("First Line is smaller than Second Line");
        }
    }
}
