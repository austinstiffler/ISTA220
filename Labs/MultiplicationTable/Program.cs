﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiplication table");
            for (int i = 1; i <= 12; i = i + 1)
            {
                //Console.Write($" {i} ");

                for (int j = 1; j <= 12; j+= 1)
                {
                     Console.Write($" {j*i} ");
                }
                Console.WriteLine();
            }
            
        }
    }
}
