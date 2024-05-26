using System;


namespace Interface
{
    class PluginManager
    {
        public void LoadPlugin(IPlugin plugin) 
        {
            plugin.Execute();
        }
    }
}
