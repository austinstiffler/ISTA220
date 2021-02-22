using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpEx06
{
    class OverhaulTeam : ResponseTeam
    {
        public override void Reflash()
        {
            Console.WriteLine("Overhaul Team is at the scene!");
            Console.WriteLine("*2 minutes later..*");
            Console.WriteLine("Overhaul Team: Chief of the Watch, no hot spots found at the scene!");
        }
    }
}
