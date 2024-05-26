using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            PluginManager manager = new PluginManager();
            manager.LoadPlugin(new CalculatorPlugin(2, 8));
            manager.LoadPlugin(new GreetingPlugin("Pavlo"));
   
            Console.ReadKey();
        }
    }
}
