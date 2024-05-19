using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
    class Bicycle : Transport
    {
        public string TypeOfBike;

        public Bicycle(string model, int maxSpeed, string typeOfBike) : base(model, maxSpeed)
        {
            this.TypeOfBike = typeOfBike;
        }

        public new void Move()
        {
            Console.WriteLine("Bike is moving:");
        }
        public override void DisplayData()
        {
            Console.WriteLine($"Model: {Model}\n" +
                $"Max speed: {MaxSpeed}\n" +
                $"Type of bike: {TypeOfBike}");
        }
    }
}
