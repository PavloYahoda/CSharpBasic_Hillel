using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
    class Transport
    {

        private string model;
        private int maxSpeed;
        public string Model { get => model; set => model = value; }
        public int MaxSpeed { get => maxSpeed; set => maxSpeed = value; }

        public Transport(string model, int maxSpeed) {
            this.Model = model;
            this.MaxSpeed = maxSpeed;
        }

        public void Move() {
            Console.WriteLine("Transport is moving.");
        }
        public virtual void DisplayData()
        {
            Console.WriteLine($"Model: {Model}\n" +
                $"MaxSpeed: {MaxSpeed}");
        }
        public static string WhoIsFaster(string modelFirstCar, int speedFirstCar,  string modelSecondCar, int speedSecondCar) {
            return speedFirstCar > speedSecondCar ? modelFirstCar : modelSecondCar;
        }
    }
}
