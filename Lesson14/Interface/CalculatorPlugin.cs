using System;


namespace Interface
{
    class CalculatorPlugin : IPlugin
    {
        public double Number1 { get; set; }
        public double Number2 { get; set; }

        public CalculatorPlugin(double number1, double number2) 
        {
            Number1 = number1;
            Number2 = number2;
        }
        void IPlugin.Execute()
        {
            Console.WriteLine($"Result of action {Number1}^{Number2}: {Math.Pow(Number1, Number2)}");
        }
    }
}
