﻿using System;

namespace No_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int alphabet, digit, i, l;
            alphabet = digit = i = 0;

            Console.Write("Enter the string : ");
            str = Console.ReadLine();
            l = str.Length;

            while (i < l)
            {
                if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z'))
                {
                    alphabet++;
                }
                else if (str[i] >= '0' && str[i] <= '9')
                {
                    digit++;
                }               

                i++;
            }

            Console.Write("Number of Alphabets in the string is : {0}\n", alphabet);
            Console.Write("Number of Digits in the string is : {0}\n", digit);            

            Console.ReadLine();
        }
    }
}
