﻿using System;

namespace Square_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double side, area;
            Console.WriteLine("Enter the Side : ");
            side = Convert.ToDouble(Console.ReadLine());
            area = side * side;
            Console.WriteLine("\nArea of Square: " + area);
            Console.ReadKey();
        }
    }
}
