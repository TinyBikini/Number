using System;

namespace Task2
{
    public class Program
    {
      public static void Main(string[] args)
        {

            
            int NOD = 0;

            Console.WriteLine("Определение НОД и НОК. Введите первое число");
            Console.WriteLine("-----------------------------------------\n");

            int number1 = GetNumber();
            Console.WriteLine("Введите второе число");
            int number2 = GetNumber();

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
        static public int GetNumber()
        {
            bool success = int.TryParse(Console.ReadLine(), out int number);
            if (!success)
            {
                Console.WriteLine("Допускается вводить только натуральные числа");
                //как прекратить дальнейшее выполнение кода? раньше стоял return, а сейчас обязательно выдать что-нибудь
                return;
            }
            else
            {
                return number;
            }
        }
    }

}
