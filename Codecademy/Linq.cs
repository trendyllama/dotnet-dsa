
using System;
using System.Collections.Generic;

namespace dotnet_dsa.Codecademy
{
   class Program
    {

        static void Main()
        {
            List<double> marathons = new List<double>();
            marathons.Add(144.07);
            marathons.Add(143.12);

            List<double> marathons2 = new List<double>{ 144.07, 143.12, 146.73, 146.33, };

            // Do not delete the code below
            double time = marathons2[1];

            Console.WriteLine($"The 2012 marathon was ran in {time} minutes!");

            Console.WriteLine(marathons[1]);

            var filteredMarathons = from marathon in marathons2
                                    where marathon < 145
                                    select marathon;

            Console.WriteLine("Marathons under 145 minutes:");
            foreach (var marathon in filteredMarathons)
            {
                Console.WriteLine(marathon);
            }
        }
    }
}