using System;

namespace PrPost
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4, num5, num6;
            Console.WriteLine("Enter the first number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            num2 = int.Parse(Console.ReadLine());
            num5= num3 = num1;
            num6= num4 = num2;
            num2 = ++num1;
            Console.WriteLine("\n Pre Increment: Number 1: {0} \t Number 2 : {1}", num1, num2);
            num4 = num3++;
            Console.WriteLine("\n Post Increment: Number 1: {0} \t Number 2 : {1}", num3, num4);
            int temp = num5;
            num5 = num6;
            num6 = temp;
            Console.WriteLine("\n After Swap: Number 1: {0} \t Number 2 : {1}", num5, num6);
        }
    }
}
