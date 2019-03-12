using System;
using System.Collections.Generic;

namespace RandomSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            List<int> squaredNumberz = new List<int>();
            Random randomNumber = new Random();
            

            for (int i = 0; i < 20; i++)
            {
                
               var radomNumbers =  randomNumber.Next(50);
                numbers.Add(radomNumbers);
               
            }
            foreach (var number in numbers)
            {
                Console.Write($"{number } {" "} ");
            }
            foreach (var squar in numbers)
            {
               int squaredNumber = squar * squar;
                squaredNumberz.Add(squaredNumber);

                Console.WriteLine(squaredNumber);
            }
            foreach (var odd in squaredNumberz )
            {
                if (odd % 2 == 0)
                {
                    Console.Write(odd);
                }
            }
            Console.ReadLine();
            {

            }
        }

    }
}
