/*
   Ввести с клавиатуры номер трамвайного билета (6-значное число) и про-
верить является ли данный билет счастливым (если на билете напечатано 
шестизначное число, и сумма первых трёх цифр равна сумме последних трёх, то 
этот билет считается счастливым).
 */

using System;

namespace LuckyTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите шестизначный номер трамвайного билета");

            int ticketNumber;
            int.TryParse(Console.ReadLine(), out ticketNumber);

            int sumFirstThree = 0;
            int sumLastThree = 0;

            if(ticketNumber < 100000 || ticketNumber > 999999)
            {
                Console.WriteLine("Введен не шестизначный номер");
                return;
            }

            for(int i = 0; i < 6; ++i)
            {
                
                if(i > 2)
                {
                    sumFirstThree += ticketNumber % 10;
                }
                else
                {
                    sumLastThree += ticketNumber % 10;
                }

                ticketNumber = ticketNumber / 10;
            }

            if(sumLastThree == sumFirstThree)
            {
                Console.WriteLine("Билет счастливый");
            }
            else
            {
                Console.WriteLine("Билет не счастливый");
            }
        }
    }
}
