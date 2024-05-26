using System;


namespace Interface
{
    class GreetingPlugin : IPlugin
    {
        public string Name;

        public GreetingPlugin(string name) 
        {
            Name = name;
        }
        public void Execute()
        {
            Console.WriteLine($"Hello {Name}! Long time no see!");
        }
    }
}
