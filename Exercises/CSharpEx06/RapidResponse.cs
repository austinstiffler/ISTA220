using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpEx06
{
    class RapidResponse : ResponseTeam
    {
        public override void InitialResponse()
        {
            Console.WriteLine("Rapid Response: Burst Burst! Fighting Fire!!");
        }

        public override void Relieve()
        {
            Console.WriteLine("Rapid Response: Chief of the Watch, it's too hot! We need reliefs, NOW!");
        }
    }
}
