using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Tristan DeMaria, CSCI-1630, 09-07-21
 * Create a program that calculates the cost of a new floor. Include cost of
 * materials and cost of labor. Have the user enter three pieces of data:
 * floor length, floor width, and flooring cost per square foot.
 * Length and width variables will be integers, cost per sqft will be a double.
 * Total cost will be a function of length * width * cost per sqft.
 * Define two constants: installation cost per hour ($37.75)
 * and sqft installed per hour (40).
 * Calculate hours of labor based on sqft / sqft installed per hour (40).
 * Determine total cost of labor by multiplying hourly labor by the result.
 * Example: sqft = 120, hours = 120 / 40 = 3, total labor cost = 3 * 37.75 = $113.25
 * Add together total labor cost with total flooring cost for final total.
 * Display all relevant information in a mixture of strings and integers.
 * See prompt online for example output.
 */

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            double hourlyInstall = 37.75;
            double sqftPerHour = 40;
            string floorLengthAsString;
            int floorLength;
            string floorWidthAsString;
            int floorWidth;
            string floorPerSQFTCostAsString;
            double floorPerSQFTCost;


            WriteLine("Welcome to Tristan's Flooring Cost Estimator!");
            WriteLine("");
            Write("Please enter length of floor area in feet: ");
            floorLengthAsString = ReadLine();
            floorLength = Convert.ToInt16(floorLengthAsString);

            Write("Please enter width of floor area in feet: ");
            floorWidthAsString = ReadLine();
            floorWidth = Convert.ToInt16(floorWidthAsString);

            Write("Please enter cost per square foot of your selected flooring material: ");
            floorPerSQFTCostAsString = ReadLine();
            floorPerSQFTCost = Convert.ToDouble(floorPerSQFTCostAsString);

            int totalSQFT = floorLength * floorWidth;
            double floorCost = totalSQFT * floorPerSQFTCost;
            double hours = totalSQFT / sqftPerHour;
            double totalLabor = hours * hourlyInstall;
            double finalTotal = totalLabor + floorCost;

            WriteLine("-------------------------------");
            WriteLine($"For a total floor size of {totalSQFT} sq. ft., the flooring cost is {floorCost.ToString("C")}");
            WriteLine($"It will take {hours} hours to install the floor at a cost of {totalLabor.ToString("C")}");
            WriteLine("");
            WriteLine($"The total finished cost for the new floor is {finalTotal.ToString("C")}");
            Console.ReadLine();
        }
    }
}
