﻿using System;


namespace Classes
{
    class Program
    {
        static void doWork()
        {
            Point origin = new Point(3, 4);
            Point origin2 = new Point();
            Point origin3 = new Point(6, 7, 8);
            Point bottomRight = new Point(1366, 768);
            Point point1 = new Point(0, 0);
            Point point2 = new Point(3, 4);
            Point origin4 = new Point(1, 2, 3);
            Console.WriteLine($"The distance between point 1 and point 2 is: {point1.DistanceTo(point2)}");
            Console.WriteLine($"The distance between point 2 and point 1 is: {point2.DistanceTo(point1)}");
            Console.WriteLine($"The distance between point 1 and point 1 is: {point1.DistanceTo(point1)}");
            Console.WriteLine($"The number of points created is: {Point.ObjectCount()}");
            Console.WriteLine($"The distance between origin 3 and origin 4 is: {origin3.DistanceTo(origin4)}");
        }

        static void Main(string[] args)
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
