using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava6
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] bytes1 = new byte[100];

            Random r = new Random();
            int rInt = r.Next(0, 100);
            int range = 100;
            Console.WriteLine(rInt);
            bool ran = true;
            Console.WriteLine("Guess a number (0-100)");
            while (ran)
            {
                
                Console.Write("Guess a number: ");
                int arvaus = int.Parse(Console.ReadLine());
                if(arvaus < rInt)
                {
                    Console.WriteLine("Number is bigger");
                }
                if(arvaus > rInt){
                    Console.WriteLine("Number is smaller");
                }
                if(arvaus == rInt)
                {
                    Console.WriteLine("onneksi olkoon olet homo :D");
                    ran = false;
                }
            }



            
        }
    }
}
   
