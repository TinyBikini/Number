﻿using System;

namespace Number
{
    class Program
    {
        static void Main(string[] args)
        {
            bool prime = true;
            int number = 0;
    
            Console.WriteLine("Введите натуральное число");
            Console.WriteLine("-------------------------\n");

            bool success = int.TryParse(Console.ReadLine(), out number);
            if (!success)
            {
                Console.WriteLine("Допускается вводить только натуральные числа");
            }
            //проверка на исключение
            else if (number == 2) Console.WriteLine("Число 2 четное и простое ");

            // проверка на четность
            else if (number % 2 == 0)
            {
                Console.WriteLine($"Число \"{number}\" четное и составное");
            }

            else
            {
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                Console.WriteLine($"Число \"{number}\" нечетное и {(prime ? "простое" : "составное")}");

            }
        }
    }
}