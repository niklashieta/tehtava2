using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int arvo = 0;
            Console.WriteLine("Anna puun korkeus: ");
            arvo = int.Parse(Console.ReadLine());
            for (int i = 0; i < arvo-2; i++)
            {
                
                for (int g = arvo; i <= g; g--)
                {

                    Console.Write(" ");
                    
                }
               
                for (int h =0; a>=h; h++)
                {
                    
                    Console.Write("*");
                    
                }
                Console.Write("\n");
                a++;
                a++;
            }
            for(int e=-1; arvo>e;e++)
            {
                Console.Write(" ");
            }Console.Write("*\n");
            for (int e = -1; arvo > e; e++)
            {
                Console.Write(" ");
            }
            Console.Write("*\n");


        }
    }
}
