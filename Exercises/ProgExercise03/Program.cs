using System;

namespace ProgExercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            partOne();
            partTwo();
            partThree();
            partFour();
        }

        private static void partOne()
        {
            Console.WriteLine("PART 1: Circumference and Area of a Circle");
            try
            {
                Console.WriteLine("Enter an integer for the radius:");
                string strRadius = Console.ReadLine();
                int intRadius = int.Parse(strRadius);
                if (intRadius <= 0)
                    throw new ArgumentOutOfRangeException("Please use a positive integer.");
                double circumference = 2 * Math.PI * intRadius;
                Console.WriteLine($"The circumference is {circumference}.");
                double area = Math.PI * (intRadius * intRadius);
                Console.WriteLine($"The area is {area}.");
            }
            catch (FormatException fEx)
            {
                Console.WriteLine(fEx.Message);
                partOne();
            }
            catch (ArgumentOutOfRangeException argEx)
            {
                Console.WriteLine(argEx.Message);
                partOne();
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
                partOne();
            }
            finally
            {
                Console.WriteLine("Okay.");
            }
        }

        private static void partTwo()
        {
            Console.WriteLine("PART 2: Volume of a Hemisphere");
            try
            {
                Console.WriteLine("Enter an integer for the radius:");
                string strRadius2 = Console.ReadLine();
                int intRadius2 = int.Parse(strRadius2);
                if (intRadius2 <= 0)
                    throw new ArgumentOutOfRangeException("Please use a positive integer.");
                double volume = ((4 / 3) * Math.PI * (intRadius2 * intRadius2 * intRadius2)) / 2;
                Console.WriteLine($"The volume is {volume}.");
            }
            catch (FormatException fEx)
            {
                Console.WriteLine(fEx.Message);
                partTwo();
            }
            catch (ArgumentOutOfRangeException argEx)
            {
                Console.WriteLine(argEx.Message);
                partTwo();
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
                partTwo();
            }
            finally
            {
                Console.WriteLine("Okay.");
            }
        }

        private static void partThree()
        {
            Console.WriteLine("PART 3: Area of a Triangle (Heron's Formula)");
            try
            {
                Console.WriteLine("Enter an integer for side 1:");
                string strSideA = Console.ReadLine();
                int intSideA = int.Parse(strSideA);
                if (intSideA <= 0)
                    throw new ArgumentOutOfRangeException("Please use a positive integer.");
                Console.WriteLine("Enter an integer for side 2:");
                string strSideB = Console.ReadLine();
                int intSideB = int.Parse(strSideB);
                if (intSideB <= 0)
                    throw new ArgumentOutOfRangeException("Please use a positive integer.");
                Console.WriteLine("Enter an integer for side 3:");
                string strSideC = Console.ReadLine();
                int intSideC = int.Parse(strSideC);
                if (intSideC <= 0)
                    throw new ArgumentOutOfRangeException("Please use a positive integer."); ;
                int halfCircum = (intSideA + intSideB + intSideC) / 2;
                double area = Math.Sqrt(halfCircum * (halfCircum - intSideA) * (halfCircum - intSideB) * (halfCircum - intSideC));
                Console.WriteLine($"The area is {area}.");
            }
            catch (FormatException fEx)
            {
                Console.WriteLine(fEx.Message);
                partThree();
            }
            catch (ArgumentOutOfRangeException argEx)
            {
                Console.WriteLine(argEx.Message);
                partThree();
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
                partThree();
            }
            finally
            {
                Console.WriteLine("Okay.");
            }
        }

        private static void partFour()
        {
            Console.WriteLine("PART 4: Solving a Quadratic Equation");
            try
            {
                Console.WriteLine("Enter the 'a' coefficient:");
                string strQuadA = Console.ReadLine();
                int intQuadA = int.Parse(strQuadA);
                Console.WriteLine("Enter the 'b' coefficient:");
                string strQuadB = Console.ReadLine();
                int intQuadB = int.Parse(strQuadB);
                Console.WriteLine("Enter the 'c' coefficient:");
                string strQuadC = Console.ReadLine();
                int intQuadC = int.Parse(strQuadC);
                double positiveSol = (-intQuadB + Math.Sqrt((intQuadB * intQuadB) - (4 * intQuadA * intQuadC))) / (2 * intQuadA);
                double negativeSol = (-intQuadB - Math.Sqrt((intQuadB * intQuadB) - (4 * intQuadA * intQuadC))) / (2 * intQuadA);
                Console.WriteLine($"The positive solution is {positiveSol}.");
                Console.WriteLine($"The negative solution is {negativeSol}.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please use a number.");
                partFour();
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
                partFour();
            }
            finally
            {
                Console.WriteLine("Okay.");
            }
        }
    }
}
