using System;



namespace Сircle_radius
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter radius: ");
                double radius = Convert.ToDouble(Console.ReadLine());
                
                double areaOfCircle = Math.PI * Math.Pow(radius, 2);
                Console.WriteLine($"Area of circle with radius equals {radius} is " + string.Format("{0:F3}", areaOfCircle));
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("You are not entering a number");
                Console.ReadKey();
            }
        }
    }
}
