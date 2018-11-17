//Grading ID:  B3697
//Program:     1
//Class:       CIS 199-75
//Due:         September 26, 2017
//Description: This is an interactive Windows Console that  will calculate the
//             number of gallons of paint needed to paint the walls in a room.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1
{
    class Program
    {
        static void Main(string[] args)
        {
            const double door = 20;        // This is a named constant for a door that is initialized to 20 sq ft
            const double window = 15;      // This is a named constant for a window that is initialized to 15 sq ft
            const double canOfPaint = 350; // This is a named constant for a can of paint that is initialized to 350 sq ft
            double totalLength;            // This variable represents the total length of all walls input by the user
            double height;                 // This variable represents the height of the walls input by the user
            double minPaint;               // This variable represents the minimum gallons of paint the user needs
            int numOfDoors;                // This variable represents the total number of doors input by the user
            int numOfWindows;              // This variable represents the total number of windows input by the user
            int numOfCoats;                // This variable represents the total number of coats of paint desired input by the user
            int gallonsToBuy;              // This variable represents the total gallons of paint the user needs to buy

            Console.WriteLine("Welcome to the Handy-Dandy Paint Estimator\n");

            Console.Write("Enter the total length of all walls (in feet): ");
            totalLength = double.Parse(Console.ReadLine());

            Console.Write("Enter the height of walls (in feet): ");
            height = double.Parse(Console.ReadLine());

            Console.Write("Enter the number of doors (non-neg int): ");
            numOfDoors = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of windows (non-neg int): ");
            numOfWindows = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of coats of paint (non-neg int): ");
            numOfCoats = int.Parse(Console.ReadLine());

            minPaint = ((totalLength * height - numOfDoors * door - numOfWindows * window) * numOfCoats) / canOfPaint;
            gallonsToBuy = (int)Math.Ceiling(minPaint);

            Console.WriteLine($"\nYou need a minimum of {minPaint:F1} gallons of paint");
            Console.WriteLine($"You'll need to buy {gallonsToBuy} gallons, though");
        }
    }
}
