using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgEx02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PART 1: Sum 10 numbers.");
            int sum = SumTenInts(0, 0);
            char letterGrade = 'X';
            Console.WriteLine($"The sum of ten integers is {sum}.");

            Console.WriteLine("PART 2: Average 10 numbers.");
            double avg = AvgTenInts(0, 0);
            letterGrade = ConvertNumericToLetterGrade(avg);
            Console.WriteLine($"The average of ten integers is {avg} and the letter grade is {letterGrade}");

            Console.WriteLine("PART 3: Average user predetermined number of scores.");
            Console.WriteLine("How many scores do you wish to enter?");
            string noScores = Console.ReadLine();
            int numScores = int.Parse(noScores);
            double avg1 = AvgUnkInts(0, 0, numScores);
            letterGrade = ConvertNumericToLetterGrade(avg1);
            Console.WriteLine($"The average of {numScores} integers is {avg1} and the letter grade is {letterGrade}");

            Console.WriteLine("PART 4: Average non-predetermined number of scores.");
            double avg2 = AvgAnyInts(0, 0);
            letterGrade = ConvertNumericToLetterGrade(avg2);
            Console.WriteLine($"The average of these integers is {avg2} and the letter grade is {letterGrade}");
        }

        private static char ConvertNumericToLetterGrade(double grade)
        {
            char letterGrade = 'X';
            if (grade >= 90.0)
                return letterGrade = 'A';
            else if (grade >= 80.0 && grade < 90.0)
                return letterGrade = 'B';
            else if (grade >= 70.0 && grade < 80.0)
                return letterGrade = 'C';
            else if (grade >= 60.0 && grade < 70.0)
                return letterGrade = 'D';
            else if (grade < 60.0)
                return letterGrade = 'F';
            else
                return letterGrade;
        }

        private static double AvgAnyInts(int sum, int count)
        {
            Console.WriteLine("Please enter a score, or -1 to stop:");
            string input = Console.ReadLine();
            sum += int.Parse(input);
            count = count + 1;
            if (input == "-1")
                return sum / count;
            else
                return AvgAnyInts(sum, count);
        }

        private static double AvgUnkInts(int sum, int count, int numScores)
        {
            Console.WriteLine("Please enter a score:");
            string input = Console.ReadLine();
            sum += int.Parse(input);
            count = count + 1;
            if (count < numScores)
                return AvgUnkInts(sum, count, numScores);
            else
                return sum / numScores;
        }

        private static double AvgTenInts(int sum, int count)
        {
            Console.WriteLine("Enter a score:");
            string input = Console.ReadLine();
            sum += int.Parse(input);
            count = count + 1;
            if (count < 10)
                return AvgTenInts(sum, count);
            else
                return sum / count;
        }

        private static int SumTenInts(int sum, int count)
        {
            Console.WriteLine("Enter a score:");
            string input = Console.ReadLine();
            sum += int.Parse(input);
            count = count + 1;
            if (count < 10)                      
                return SumTenInts(sum, count);
            else                            
                return sum;
        }
    }
}
