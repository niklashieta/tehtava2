using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava4
{
    class Program
    {
        static void Main(string[] args)
        {
            int gra0 = 0;
            int gra1 = 0;
            int gra2 = 0;
            int gra3 = 0;
            int gra4 = 0;
            int gra5 = 0;
            int[] arr = new int[100];
            bool run = true;
            int i = 0;
            Console.Write("when you want to end input use x\n");
            while (run)
            {
                Console.Write("Give Grade: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int number))
                {
                    arr[i] = number;
                    switch (number)
                    {
                        case 0: gra0++; break;
                        case 1: gra1++; break;
                        case 2: gra2++; break;
                        case 3: gra3++; break;
                        case 4: gra4++; break;
                        case 5: gra5++; break;
                    }


                }
                else
                {
                    if (input == "x")
                    {
                        run = false;
                    }
                    else
                    {
                        Console.Write("thats not a number\n");
                    }
                }
                i++;

            }

            Console.WriteLine("Grades:");
            Console.Write("0:");
            for (int h = 1; h <= gra0; h++)
            {
                Console.Write("*");
            }
            Console.Write("\n1:");
            for (int a = 1; a <= gra1; a++)
            {
                Console.Write("*");
            }
            Console.Write("\n2:");
            for (int b = 1; b <= gra2; b++)
            {
                Console.Write("*");
            }
            Console.Write("\n3:");
            for (int c = 1; c <= gra3; c++)
            {
                Console.Write("*");
            }
            Console.Write("\n4:");
            for (int d = 1; d <= gra4; d++)
            {
                Console.Write("*");
            }
            Console.Write("\n5:");
            for (int e = 1; e <= gra5; e++)
            {
                Console.Write("*");
            }
            Console.Write("\n");
        }
    }
}

