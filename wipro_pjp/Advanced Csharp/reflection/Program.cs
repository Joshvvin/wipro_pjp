using System;
using System.Reflection;

namespace reflection
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Type t = Type.GetType("reflection.Customer");
            Console.WriteLine("*** " + t.AssemblyQualifiedName);
            Console.WriteLine("***** " + t.Namespace);
            Console.WriteLine("******* " + t.Name);
            ConstructorInfo[] constructors = t.GetConstructors();
            foreach(ConstructorInfo constructor in constructors)
            {
                Console.WriteLine("********* " + constructor.ToString());               
            }            
            PropertyInfo[] properties = t.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine("********* " + property.ToString());                
            }          
            MethodInfo[] methods = t.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine("********* " + method.ToString());                
            }            
        }
    }
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Customer(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public Customer()
        {
            this.Id = -1;
            this.Name = string.Empty;
        }
        public void printid()
        {
            Console.WriteLine("Id : " + this.Id);
        }
        public void printname()
        {
            Console.WriteLine("Name : " + this.Name);
        }
    }
}
