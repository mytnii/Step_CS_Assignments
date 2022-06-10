/*
   Написать программу, которая считывает символы с клавиатуры, пока не 
будет введена точка. Программа должна сосчитать количество введенных 
пользователем пробелов.
 */

using System;

namespace SubtractinOfGaps
{
    public class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string? str;
            do
            {
                Console.WriteLine("Введите символ");
                Console.WriteLine(" . - завершение программы ");

                str = Console.ReadLine();

                if (str.Length > 1)
                {
                    Console.WriteLine("Введено больше одного символа");
                }
                else if (str == " ")
                {
                    ++count;
                }


            } while (str != ".");

            Console.WriteLine($"Введено пробелов: {count}");
        }


    }
}
