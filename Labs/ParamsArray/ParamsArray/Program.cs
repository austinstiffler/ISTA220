using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsArray
{
    class Program
    {
        static void doWork()
        {
            //Console.WriteLine(Util.Sum(null));
            //Console.WriteLine(Util.Sum());
            Console.WriteLine(Util.Sum(10, 9, 8, 7, 6, 5, 4, 3, 2, 1));
            Console.WriteLine(Util.Sum(50));
            Console.WriteLine(Util.Sum(2, 7));
            Console.WriteLine(Util.Sum(46, 90, 3));
            Console.WriteLine(Util.Sum(33, 44, 55, 66, 77));
            Console.WriteLine(Util.Sum(22, 1, 6, 99, 49));
            Console.WriteLine(Util.Sum(100, 37, 87, 24, 42, 9));
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
