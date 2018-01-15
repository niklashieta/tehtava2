using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carapplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //TemperatureConverter converter = new TemperatureConverter();
            double temp = TemperatureConverter.FahrenheitToCelsius(200);

            car datsun = new car("datsun 100A","Red", 1.0,true,2);
            car porcshe = new car("porcshe 911 RS3", "Silver", 3.2, true, 2);
            car Toyota = new car("Toyota Camry", "Green", 2.2, true, 4);

            datsun.Speed = 100;
            porcshe.Speed = 180;
            Toyota.Speed = 200;

            // display car data
            datsun.PrintData();
            porcshe.PrintData();
            Toyota.PrintData();
            Console.ReadLine();
            // accelerate, change car's speed value
            datsun.Accelerate();
            // display car data again, notice changed speed value!
            datsun.PrintData();
            Console.ReadLine();
        }
    }
}
