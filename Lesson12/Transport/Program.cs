using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
    class Program
    {
        static void Main(string[] args)
        {
            Car bmw = new Car("BMW i5 M60 xDrive ", 250, 4);
            bmw.Move();
            bmw.DisplayData();

            Car subaru = new Car("Subaru BRZ tS", 320, 2);
            subaru.Move();
            subaru.DisplayData();

            Console.WriteLine($"{Transport.WhoIsFaster(bmw.Model, bmw.MaxSpeed, subaru.Model, subaru.MaxSpeed)} is faster.");
            Console.WriteLine("-----------------------------------");

            Bicycle giant = new Bicycle("Giant Yukon", 60, "Mountain");
            giant.Move();
            giant.DisplayData();

            Bicycle pride = new Bicycle("PRIDE ROCX 8.3 frame", 50, "Adventure");
            pride.Move();
            pride.DisplayData();

            Console.WriteLine($"{Transport.WhoIsFaster(giant.Model, giant.MaxSpeed, pride.Model, pride.MaxSpeed)} is faster.");
            Console.ReadKey();
        }
    }
}
