using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carapplication
{
    class car
    {
        private static int MaxSpeed = 200;
        public string Model { get; set; }
        public string Color { get; set; }
        public double Engine { get; set; }
        private int speed;
        public int Speed
        {
            get { return speed; }
            set
            {
                if (value <= MaxSpeed) speed = value;
                else speed = MaxSpeed;
            }
        }
        public bool FuzzyDices { get; set; }
        public int DoorCount { get; set; }

        public void Accelerate()
        {
            Speed += 62;
        }

        // method to slow down
        public void Brake()
        {
            Speed -= 5;
        }
        public void PrintData()
        {
            Console.WriteLine("Car data : ");
            Console.WriteLine("- model : " + Model);
            Console.WriteLine("- color : " + Color);
            Console.WriteLine("- engine size : " + Engine);
            Console.WriteLine("- speed : " + Speed);
            Console.WriteLine("- fuzzy dices : " + FuzzyDices);
            Console.WriteLine("- door count : " + DoorCount);
        }

        // destructor
        ~car()
        {
            Console.WriteLine("Car object destroyed.");
        }
        public car(string model, string color, double engine, bool fuzzyDices, int doorCount)
        {
            Model = model;
            Color = color;
            Engine = engine;
            FuzzyDices = fuzzyDices;
            DoorCount = doorCount;


        }
    }
}
