using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string PersonName;
            PersonName = "Oraz";

            Console.WriteLine("Привет, мир!");
            Console.WriteLine("\t Меня зовут \n \t {0}", PersonName);
            Console.WriteLine("\x23 ");


            
            byte age = 22;
            double shoe_size = 45;
            bool HaveIApet = false;
            Console.WriteLine("My name is " + PersonName);
            Console.WriteLine("My age is " + age);
            Console.WriteLine("Do I have a pet? " + HaveIApet);
            Console.WriteLine("My shoe size is " + shoe_size);

            Console.ReadKey();


        }
    }
}
