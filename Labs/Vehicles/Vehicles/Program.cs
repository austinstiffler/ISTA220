using System;

namespace Vehicles
{
    class Program
    {
        static void doWork()
        {
            Console.WriteLine("Test Vehicle");
            Vehicle v = new Vehicle();
            v.StartEngine("RUM RUM");
            v.Drive();
            v.StopEngine("GIN GIN");

            Console.WriteLine("-------------------------------------");

            Console.WriteLine("Journey by airplane:");
            Airplane myPlane = new Airplane();
            myPlane.StartEngine("Contact");
            myPlane.TakeOff();
            myPlane.Drive();
            myPlane.Land();
            myPlane.StopEngine("Whirr");

            Console.WriteLine("------------------------------------");

            Console.WriteLine("Journey by car:");
            Car myCar = new Car();
            myCar.StartEngine("Brm brm");
            myCar.Accelerate();
            myCar.Drive();
            myCar.Brake();
            myCar.StopEngine("Phut phut");

            Console.WriteLine("-------------------------------------");

            Console.WriteLine("\nTesting polymorphism");
            Vehicle w = new Vehicle();
            w.Drive();
            w = myCar;
            w.Drive();
            w = myPlane;
            w.Drive();

            Console.WriteLine("-------------------------------------");

            Console.WriteLine("Journey by motorcycle:");
            Motorcycle myMotorcycle = new Motorcycle();
            myMotorcycle.StartEngine("Hoooonnnndaaaa");
            myMotorcycle.Accelerate();
            myMotorcycle.Drive();
            myMotorcycle.Brake();
            myMotorcycle.StopEngine("Clunk");
        }

        static void Main()
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
        }
    }
}
