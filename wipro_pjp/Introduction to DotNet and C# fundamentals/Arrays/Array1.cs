using System;

namespace Array1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;           

            int[] arr= { 3, 5, 7, 1, 2, 6 };

            Console.WriteLine("The elements in the array are: ");
            foreach(int i in arr)
            {
                Console.Write(i+ " ");
                count++;
            }

            Console.WriteLine("\nNumber of elements :{0}", count);
            Console.ReadKey();
            
        }
    }
}
