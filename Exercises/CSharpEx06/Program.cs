using System;

namespace CSharpEx06
{
    class Program
    {
        static void submarineFire()
        {
            Console.WriteLine("Example of a submarine fire scenario.");

            ChiefOfTheWatch c = new ChiefOfTheWatch();
            RapidResponse rr = new RapidResponse();
            FFETeam f = new FFETeam();
            OverhaulTeam o = new OverhaulTeam();
            AtmosphereMonitoring a = new AtmosphereMonitoring();
            ResponseTeam t = new ResponseTeam();

            c.InitialResponse();
            rr.InitialResponse();

            rr.Relieve();
            c.Relieve();
            f.Relieve();

            f.Reflash();
            c.Reflash();
            o.Reflash();

            c.Ventilate();

            c.Atmosphere();
            a.Atmosphere();

            c.Secure();
        }
       

            static void Main(string[] args)
        {
            try
                {
                    submarineFire();
                }
            catch (Exception ex)
                {
                    Console.WriteLine("Exception: {0}", ex.Message);
                }
        }
    }
}
