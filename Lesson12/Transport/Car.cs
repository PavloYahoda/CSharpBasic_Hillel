using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
    class Car : Transport
    {
        public int CountOfDoors;

        public Car(string model, int maxSpeed, int countOfDoors) : base(model, maxSpeed) {
            this.CountOfDoors = countOfDoors;
        }

        public new void Move()
        {
            Console.WriteLine("Car is moving:");
        }
        public override void DisplayData()
        {
            Console.WriteLine($"Model: {Model}\n" +
                $"Max speed: {MaxSpeed}\n" +
                $"Count of doors: {CountOfDoors}");
        }
    }
}
