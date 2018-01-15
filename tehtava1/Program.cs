using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give a number: ");
            int number = int.Parse(Console.ReadLine());
            for(int i = 0; i <= number+i; i++)
            {
                number--;
                Console.Write("\n");
                for (int h=number;0<=h;h--)
                {
                    Console.Write("*");
                }
            }
        }
    }
}
