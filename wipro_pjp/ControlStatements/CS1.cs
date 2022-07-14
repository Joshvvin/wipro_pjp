using System;

namespace Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            int num = 3;
            bool f = false;
            while(num > 0)
            {
                Console.WriteLine("Enter the username :");
                string user = Console.ReadLine();
                Console.WriteLine("Enter the password :");
                string pass = Console.ReadLine();
                if (user=="admin"&&pass == "admin")
                {
                    f = true;
                    Console.WriteLine("Login Successful");
                    break;
                }
                num--;
                Console.WriteLine("Incorrect username or password\nTry again");
            }
            if (!f)
                Console.WriteLine("Login Failed");
        }
    }
}
