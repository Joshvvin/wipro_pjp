using System;

public delegate void deladd(int a, int b);
public delegate void deldiv(int a, int b);
public delegate void delsub(int a, int b);
public delegate void delmul(int a, int b);
class Program
    {
        public static void Main(string[] args)
        {
        Console.WriteLine("Enter the first number: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number: ");
        int b = int.Parse(Console.ReadLine());
        deladd da = new deladd(add);
        da(a, b);
        delsub ds = new delsub(sub);
        ds(a, b);
        delmul dm = new delmul(mul);
        dm(a, b);
        deldiv dd = new deldiv(div);
        dd(a, b);
    }
        public static void add(int a, int b)
        {
        int result = a + b;
        Console.WriteLine( a+" + " + b + " is : " + result);
        }
        public static void sub(int a, int b)
        {
            int result = a - b;
            Console.WriteLine(a + " - " + b + " is : " + result);
        }
        public static void mul(int a, int b)
        {
        int result = a * b;
        Console.WriteLine(a + " * " + b + " is : " + result);
        }
        public static void div(int a, int b)
        {
        int result = a / b;
        Console.WriteLine(a + " / " + b + " is : " + result);
        }
}

