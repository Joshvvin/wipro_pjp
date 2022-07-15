using System;

namespace Salary
{
    class employee
    {
        String Name;
        double Basesalary,HRA,GROSS,DA,TAX,NetPay;

        public employee(string name, double bas)
        {
            this.Name = name;
            this.Basesalary = bas;
        }
        public void CalculateNetPay(String name,double bas)
        {
            this.HRA = 0.15 * bas;
            this.DA = 0.10 * bas;
            this.GROSS = this.Basesalary + this.DA + this.HRA;
            this.TAX = 0.08 * this.GROSS;
            this.NetPay = this.GROSS - this.TAX;   
        }
        public void Display()
        {
            Console.WriteLine("NAME      \t{0}\nBASE SALARY  \t{1}\nHRA       \t{2}\nDA        \t{3}\nGROSS PAY \t{4}\nTAX       \t{5}\nNET PAY   \t{6}",this.Name,this.Basesalary,this.HRA,this.DA,this.GROSS,this.TAX,this.NetPay);
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Name :");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Base Salary :");            
            double bas = Convert.ToDouble(Console.ReadLine());
            employee emp1 = new employee(name, bas);
            emp1.CalculateNetPay(name, bas);
            emp1.Display();
        }
    }
}
