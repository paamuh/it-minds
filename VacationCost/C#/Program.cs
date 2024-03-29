﻿using System;

namespace VacationCost
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("Not enough input arguments to run this program");
                Console.ReadLine();

                return;
            }

            var transportMethod = args[0];
            var distance = args[1];

            var calculator = new VacationCostCalculator();

            var result = calculator.CostOfVacation(transportMethod, distance);
            

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
