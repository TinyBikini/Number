using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 0;
            int number2 = 0;
            int NOD = 0;

            Console.WriteLine("Определение НОД и НОК. Введите первое число");
            Console.WriteLine("-----------------------------------------\n");

            bool success = int.TryParse(Console.ReadLine(), out number1);
            if (!success)
            {
                Console.WriteLine("Допускается вводить только натуральные числа");
                return;
            }
            Console.WriteLine("Введите второе число");
            success = int.TryParse(Console.ReadLine(), out number2);
            if (!success)
            {
                Console.WriteLine("Допускается вводить только натуральные числа");
                return;
            }
            //Переменные для хранения исходных чисел для расчета НОК
            int numberNok1 = number1;
            int numberNok2 = number2;

            //определение НОД по алгоритму Евклида
            while (number1 != number2)
            {
                if (number1 > number2)
                {
                    number1 -= number2;
                }
                else
                {
                    number2 -= number1;
                }
                NOD = number2;
               
            }
            // Определение НОК используя НОД
            int NOK = (numberNok1 * numberNok2) / NOD;
                 
            Console.WriteLine($"НОД = {NOD}");
            Console.WriteLine($"НОК = {NOK}");

        }
    }
}
