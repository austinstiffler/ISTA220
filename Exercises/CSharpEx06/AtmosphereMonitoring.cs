using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpEx06
{
    class AtmosphereMonitoring : ResponseTeam
    {
        public override void Atmosphere()
        {
            Console.WriteLine("Atmosphere Monitoring has arrived to the scene.");
            Console.WriteLine("*10 minutes later*");
            Console.WriteLine("Atmosphere Monitoring: Chief of the Watch, smoke has completely cleared the scene. Atmospheres are safe for breathing.");
        }
    }
}
