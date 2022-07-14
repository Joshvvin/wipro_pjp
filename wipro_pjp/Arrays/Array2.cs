using System;

namespace Array2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int i,sum=0,min=9999,max=0;

            //Reads elements in array
            Console.WriteLine("Enter elements in array: ");
            for (i = 0; i < 10; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                sum += array[i];
                if (array[i] < min)
                {
                    min = array[i];
                }
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            Array.Sort(array);
            //Print array in reversed order
            Console.WriteLine("\nArray in descending order: ");
            for (i = 9; i >= 0; i--)
            {
                Console.Write("\t" + array[i]);
            }
            Console.WriteLine("\nMin value of the array is: " + min);
            Console.WriteLine("Max value of the array is: " + max);
            Console.WriteLine("Sum of the elements of the array is : " + sum);
            Console.ReadLine();
        }
    }
}
