using System;
using System.Collections.Generic;

namespace Fibonacci_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeF = 0;
            // Получение числа от пользователя.
            Console.WriteLine("Какое число фибоначи вы хотите увидеть?\nВедите число");

            string sizeFibonacciInStr = Console.ReadLine();
            if ( int.TryParse(sizeFibonacciInStr, out int result) )
            {
                sizeF = int.Parse(sizeFibonacciInStr);
            }
            else
            {
                Console.WriteLine("Ой а ты меня хотел(а) обмануть(((");
                Environment.Exit(500);
            }

            int[] fibonacci = new int[sizeF];

            // Вызов метода для вычисления чисел фибоначи по заданому числу пользователя.
            fibonacci = CalcilateFibonacciNumbers(sizeF, fibonacci);

            // Вывод результата полученых числе фибоначи.
            foreach (int resultF in fibonacci )
            {
                Console.WriteLine(resultF);
            }

        }

        static int [] CalcilateFibonacciNumbers(int sizeF, int [] fibonacci)
        {
            // Это первые числа фибоначи.
            fibonacci[0] = 0;
            fibonacci[1] = 1;

            for ( int i = 2; i < sizeF; i++ )
            {
                fibonacci[i] = fibonacci[i - 2] + fibonacci[i - 1];
            }

            return fibonacci;
        }

    }
}
