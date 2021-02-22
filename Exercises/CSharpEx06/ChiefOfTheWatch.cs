using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpEx06
{
    class ChiefOfTheWatch : ResponseTeam
    {
        public override void InitialResponse()
        {
            Console.WriteLine("COW: FIRE! FIRE IN THE TORPEDO ROOM!");
            Console.WriteLine("COW: The fire main is pressurized!");
            Console.WriteLine("COW: Hose Team 1, man forward lower level hose! Hose Team 2, man forward third level hose!");
        }

        public override void Relieve()
        {
            Console.WriteLine("COW: FFE Team, relieve at the scene!");
   
        }

        public override void Reflash()
        {
            Console.WriteLine("COW: Reflash watch is stationed. Overhaul Team, report to the scene.");
        }

        public override void Ventilate()
        {
            Console.WriteLine("COW: No hot spots were found at the scene. Prepare to emergency ventilate the Torpedo Room!");
            Console.WriteLine("*3 minutes later...*");
            Console.WriteLine("COW: Commence emergency ventilating!");
            Console.WriteLine("*Smoke starts to leave the scene and affected compartment*");
        }

        public override void Atmosphere()
        {
            Console.WriteLine("COW: Smoke has left the Torpedo Room.");
            Console.WriteLine("COW: Atmosphere Monitoring Team, report to the scene.");
        }

        public override void Secure()
        {
            Console.WriteLine("COW: Atmospheres are safe for breathing, DOFF breathing equipment.");
            Console.WriteLine("COW: Secure from fire and general emergency. Secure all damage control equipment.");
        }
    }
}
