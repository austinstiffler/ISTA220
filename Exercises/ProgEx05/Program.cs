using System;

namespace ProgEx05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programming Exercise 05!");

            int[] arrayA = { 0, 2, 4, 6, 8, 10 };
            int[] arrayB = { 1, 3, 5, 7, 9 };
            int[] arrayC = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };

            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine("Part 1: Counting, summing, computing the mean..");

            part1A(arrayA);
            part1B(arrayB);
            part1C(arrayC);

            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine("Part 2: Reversing arrays..");

            part2A(arrayA);
            part2B(arrayB);
            part2C(arrayC);

            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine("Part 3: Rotating arrays..");

            Console.WriteLine("Rotate Array A left by 2 places.");
            part3A(arrayA, "left", 2);
            Console.WriteLine("Rotate Array B right by 2 places.");
            part3B(arrayB, "right", 2);
            Console.WriteLine("Rotate Array C left by 4 places.");
            part3C(arrayC, "left", 4);

            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine("Part 4: Sorting arrays..");

            Console.WriteLine("Sorting Array A:");
            part4A(arrayA);
            Console.WriteLine("Sorting Array B:");
            part4B(arrayB);
            Console.WriteLine("Sorting Array C:");
            part4C(arrayC);

        }

        public static void part1A(int[] arrayA)
        {
            double part1ASum = 0;
            double part1AMean;
            int countA;
            for (countA = 0; countA < arrayA.Length; countA++)
            {
                part1ASum += arrayA[countA];
            }

            part1AMean = part1ASum / countA;

            Console.WriteLine($"Array A: The count is {countA}. The sum is {part1ASum}. The mean is {part1AMean}.");
        }

        public static void part1B(int[] arrayB)
        {
            double part1BSum = 0;
            double part1BMean;
            int countB;
            for (countB = 0; countB < arrayB.Length; countB++)
            {
                part1BSum += arrayB[countB];
            }

            part1BMean = part1BSum / countB;

            Console.WriteLine($"Array B: The count is {countB}. The sum is {part1BSum}. The mean is {part1BMean}.");
        }

        public static void part1C(int[] arrayC)
        {
            double part1CSum = 0;
            double part1CMean;
            int countC;
            for (countC = 0; countC < arrayC.Length; countC++)
            {
                part1CSum += arrayC[countC];
            }

            part1CMean = part1CSum / countC;

            Console.WriteLine($"Array C: The count is {countC}. The sum is {part1CSum}. The mean is {part1CMean}.");
        }

        public static void part2A(int[] arrayA)
        {
            Console.WriteLine("Reverse of Array A:");
            for (int iA = arrayA.Length - 1; iA >= 0; iA--)
            {
                Console.WriteLine($"{arrayA[iA]}");
            }
        }

        public static void part2B(int[] arrayB)
        {
            Console.WriteLine("Reverse of Array B:");
            for (int iB = arrayB.Length - 1; iB >= 0; iB--)
            {
                Console.WriteLine($"{arrayB[iB]}");
            }
        }

        public static void part2C(int[] arrayC)
        {
            Console.WriteLine("Reverse of Array C:");
            for (int iC = arrayC.Length - 1; iC >= 0; iC--)
            {
                Console.WriteLine($"{arrayC[iC]}");
            }
        }

        public static void part3A(int[] arrayA, string directionA, int placesA)
        {
            int LengthA = arrayA.Length;

            if (directionA == "right")
            {
                placesA = LengthA - placesA;
            }

            for (int iA = 0; iA < LengthA; iA++)
            {
                Console.Write($"{arrayA[(iA + placesA) % LengthA]}");
            }

            Console.WriteLine();
        }

        public static void part3B(int[] arrayB, string directionB, int placesB)
        {
            int LengthB = arrayB.Length;

            if (directionB == "right")
            {
                placesB = LengthB - placesB;
            }

            for (int iB = 0; iB < LengthB; iB++)
            {
                Console.Write($"{arrayB[(iB + placesB) % LengthB]}");
            }

            Console.WriteLine();
        }

        public static void part3C(int[] arrayC, string directionC, int placesC)
        {
            int LengthC = arrayC.Length;

            if (directionC == "right")
            {
                placesC = LengthC - placesC;
            }

            for (int iC = 0; iC < LengthC; iC++)
            {
                Console.Write($"{arrayC[(iC + placesC) % LengthC]}");
            }

            Console.WriteLine();
        }

        public static void part4A(int[] arrayA)
        {
            int lengthA = arrayA.Length;

            for (int a = 0; a < lengthA; a++)
            {

                for (int A = a + 1; A < lengthA; A++)
                {
                    if (arrayA[a] > arrayA[A])
                    {
                        int temp = arrayA[a];
                        arrayA[a] = arrayA[A];
                        arrayA[A] = temp;
                    }
                }
                Console.WriteLine("{0}", arrayA[a]);
            }
            Console.WriteLine();
        }

        public static void part4B(int[] arrayB)
        {
            int lengthB = arrayB.Length;

            for (int b = 0; b < lengthB; b++)
            {

                for (int B = b + 1; B < lengthB; B++)
                {
                    if (arrayB[b] > arrayB[B])
                    {
                        int temp = arrayB[B];
                        arrayB[b] = arrayB[B];
                        arrayB[B] = temp;
                    }
                }
                Console.WriteLine("{0}", arrayB[b]);
            }
            Console.WriteLine();
        }

        public static void part4C(int[] arrayC)
        {
            int lengthC = arrayC.Length;

            for (int c = 0; c < lengthC; c++)
            {

                for (int C = c + 1; C < lengthC; C++)
                {
                    if (arrayC[c] > arrayC[C])
                    {
                        int temp = arrayC[C];
                        arrayC[c] = arrayC[C];
                        arrayC[C] = temp;
                    }
                }
                Console.WriteLine("{0}", arrayC[c]);
            }
            Console.WriteLine();
        }


    }

}
