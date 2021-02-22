using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpEx06
{
    class ResponseTeam
    {
        public virtual void InitialResponse()
        {
            Console.WriteLine("Put the fire out!!!!");
        }

        public virtual void Relieve()
        {
            Console.WriteLine("It's too hot! Relieve the rapid responders!");
        }

        public virtual void Reflash()
        {
            Console.WriteLine("Station the reflash watch.");
        }

        public virtual void Ventilate()
        {
            Console.WriteLine("Commence ventilating!");
        }

        public virtual void Atmosphere()
        {
            Console.WriteLine("No smoke!");
        }

        public virtual void Secure()
        {
            Console.WriteLine("Secure from fire and general emergency.");
        }
    }
}
