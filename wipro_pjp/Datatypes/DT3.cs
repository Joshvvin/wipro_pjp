using System;

namespace String_Incre
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1;
            char[] arr1;
            Console.Write("Enter String : ");
            str1 = Console.ReadLine();
            char ch;
            arr1 = str1.ToCharArray(0, str1.Length);
                       
            
            for( int i=0; i< str1.Length; i++)
            {
                ch = arr1[i];
                
                char ch1= (char)(ch+1);
                if (Char.IsLower(ch1))
                    Console.Write(Char.ToUpper(ch1));
                else
                    Console.Write(Char.ToLower(ch1));
            }
           
            Console.ReadKey();
        }
    }
}
