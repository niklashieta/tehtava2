using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number;
            int sum = 0;
            number = new int[5];
            for (int i = 0; i <= 4; i++)
            {
                Console.Write("anna pisteet >");
                number[i] = int.Parse(Console.ReadLine());
            }
            for (int h=0; h<=4; h++)
            {
                sum += number[h];
            }
            Console.Write(sum - 10);
        }
    }
}
