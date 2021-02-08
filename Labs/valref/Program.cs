using System;

namespace valref
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("this is valref");
            Console.WriteLine("declare an int var named carol and init to 42");
            int carol = 42;
            pasbyval(carol);
            Console.WriteLine($"after calling passbyval, carol is {carol}");

            passbyref(ref carol);
            Console.WriteLine($"\nafter calling passbyval, carol is {carol}");

            int dave;
            helloToDave(out dave);
            Console.WriteLine($"dave is {dave}");

            int ellen;
            ellen = giveEllenAValue();
            Console.WriteLine($"ellen is {ellen}");
        }

        private static int giveEllenAValue()
        {
            return 101;
        }

        private static void helloToDave(out int dave)
        {
            dave = 100;
        }

        private static void passbyref(ref int carol)
        {
            Console.WriteLine($"in passbyref({carol})");
            carol++;
            Console.WriteLine($"this will print {carol}"); // prints 43
        }

        private static void pasbyval(int carol)
        {
            Console.WriteLine($"in passbyval({carol})");
            carol++;
            Console.WriteLine($"this will print {carol}"); // prints 42
        }
    }
}
