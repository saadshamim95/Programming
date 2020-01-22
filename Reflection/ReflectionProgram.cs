using System;
using System.Reflection;

namespace Design_Pattern
{
    public class ReflectionProgram
    {
        public void Test()
        {
            Type T = Type.GetType("Design_Pattern.Customer");
            Console.WriteLine("Full Name: " + T.FullName);
            Console.WriteLine("Namespace: " + T.Namespace);
            Console.WriteLine("Class Name:" + T.Name);

            Console.WriteLine();
            Console.WriteLine("Properties of Customer Class:");
            PropertyInfo[] properties = T.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.PropertyType + " " + property.Name);
            }

            Console.WriteLine();
            Console.WriteLine("Methods of Customer Class");
            MethodInfo[] methods = T.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType + " " + method.Name);
            }
        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Customer(int ID, string Name)
        {
            this.Id = ID;
            this.Name = Name;
        }

        public Customer()
        {
            this.Id = -1;
            this.Name = string.Empty;
        }

        public void PrintID()
        {
            Console.WriteLine("ID = {0}" + this.Id);
        }

        public void PrintName()
        {
            Console.WriteLine("Name = {0}" + this.Name);
        }
    }
}