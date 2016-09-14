using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day2Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a console application that asks the user for an integer. 
            //If that integer is evenly divisible by 3, then write “You Won!” 
            //If it isn’t, write “You Lost.” Keep asking them for a number (looping) until they win.
            int number = 0;
            do
            {
                Console.WriteLine("Please enter an interger.");
                number = int.Parse(Console.ReadLine());
                if (number % 3 != 0)
                {
                    Console.WriteLine("You Lost, Try again");
                }
            } while ((number % 3 != 0));
            Console.WriteLine("You Won\a\a\a");
        }
    }
}
