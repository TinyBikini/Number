using System;

namespace Task2
{

    public class Program
    {
      public static void Main(string[] args)
        {                       
            int NOD = 0;

            Console.WriteLine("Определение НОД и НОК");
            Console.WriteLine("----------------------");

            if (!GetNumber("первое", out int number1) || !GetNumber("второе", out int number2))
            {
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
        public static bool GetNumber(string message, out int value)
        {
            Console.WriteLine($"Введите {message} число");
            string input = Console.ReadLine();
            bool success = int.TryParse(input, out value);
            if (!success)
            {
                Console.WriteLine("Допускается вводить только натуральные числа");
            }
            return success;

        }
    }

}
