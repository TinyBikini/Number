using System;

namespace Number
{
    class Program
    {
        static void Main(string[] args)
        {
            bool prime = true;
            //int number = 0;
    
            Console.WriteLine("Введите натуральное число");
            Console.WriteLine("-------------------------\n");

            bool success = int.TryParse(Console.ReadLine(), out int number);
            if (!success)
            {
                Console.WriteLine(number);
                return;
            }
            //проверка на исключение
            if (number == 2)
            {
                Console.WriteLine("Число 2 четное и простое ");
                return;
            }
            // проверка на четность
            if (number % 2 == 0)
            {
                Console.WriteLine($"Число \"{number}\" четное и составное");
                return;
            }


            for (int i = 2; i <= Math.Sqrt(number) || prime == false; i++)
            {
                if (number % i == 0)
                {
                    prime = false;
                }
            }
             
            Console.WriteLine($"Число \"{number}\" нечетное и {(prime ? "простое" : "составное")}");


        }
    }
}
