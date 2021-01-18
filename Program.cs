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
            Console.ReadKey();
        }
    }
}
