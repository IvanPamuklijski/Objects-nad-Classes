﻿using System;
using System.Numerics;

namespace _02._Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            FactorialCalculator calculator = new FactorialCalculator(n);

            Console.WriteLine(calculator.Calculate());
        }
    }
}