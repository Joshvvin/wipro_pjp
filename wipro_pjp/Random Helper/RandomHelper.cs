using System;
using System.Collections.Generic;
using System.Text;

namespace RandomHelper
{
    class RandomHelper
    {
        public static int randint(int a,int b)
        {
            Random num = new Random();
            return num.Next(a, b);
        }
        public static double randdouble(double a,double b)
        {
            Random num = new Random();
            return num.NextDouble()*(b-a)+a;
        }
    }
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter first number :");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number :");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Random Number between {0} and {1} is {2} ", a, b, RandomHelper.randint(a, b));
            Console.WriteLine("Enter first double :");
            double d1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second double :");
            double d2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Random double between {0} and {1} is {2} ", d1, d2, RandomHelper.randdouble(d1, d2));
        }
    }
}
