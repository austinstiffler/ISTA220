using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpEx06
{
    class FFETeam : ResponseTeam
    {
        public override void Relieve()
        {
            Console.WriteLine("FFE Team: Rapid Response, I relieve you!");
            Console.WriteLine("*20 seconds later...*");
            Console.WriteLine("FFE Team: THE FIRE IS OUT!");
        }

        public override void Reflash()
        {
            Console.WriteLine("FFE Team: Chief of the watch, reflash watch is stationed at the scene.");
        }
    }
}
