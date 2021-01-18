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

            DaysOfWeek MyFavoriteDay;

            MyFavoriteDay = DaysOfWeek.Friday;

            Console.WriteLine(MyFavoriteDay);
            

            Semaphore Semaphore_Color;
            Semaphore_Color = Semaphore.Green;

            Console.WriteLine("Semaphore color is " + Semaphore_Color);
            Console.ReadKey();

            double result = 10 % 3;
            Console.WriteLine("10 % 3 = {0}", result);
            Console.ReadKey();



        }
        enum DaysOfWeek : byte
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        enum Semaphore : int
        {
            Green = 100,
            Yellow = 200,
            Red = 300
        }




    }
}
