using System;
using System.Text.RegularExpressions;
using DealerOnMarsRover;

//Rover: (X, Y, Z) => x= x-xcoordinate, y=y-coordinate, z= heading => (North, South, East, West)


//Plateau: Size denominated by first line (x, y) => (5, 5) would be a 6x6 grid (starting from 0, up to 5)
//     (0,0) is Southwest corner of grid
//      MaxCoordinates => (maxX, MaxY) => (5, 5)

//Instructions: (aaaaaaa) => a in (L, R, M) =>  (TurnLeft, TurnRight, MoveForward)

//Input: 5 lines
//      1. Plateau Size: (5 5)
//      2. Two Rover instructions (2 lines each) containing
//          a. RoverPosition + heading
//          b. RoverCommand

//Rover should 
//TurnLeft
//TurnRight
//MoveForward

namespace DealerOn
{
    class Program
    {
        static void Main(string[] args)
        {
            //string plateauSize;
            Console.WriteLine("Hello, and welcome to Nicholas Dobos' (NASA's) mars rover. Please, enter an integer between 1 and 100 to provide a width for the plateau.");

            int plateauWidth = 0;
            int plateauHeight = 0;
            char heading = '\0';
            int roverXcoord = 0;
            int roverYcoord = 0;
            string roverPosition = "";
            string roverCommand = "";

            Regex Validator = new Regex(@"^[LRM]+$");

            bool IsValid(string str)
            {
                return Validator.IsMatch(str);
            }

            while (plateauWidth <= 1 || plateauWidth >= 100)
            {
                Console.WriteLine("Please provide an integer between 1 and 100, it will be the width of the plateau");
                string userInput = Console.ReadLine();
                try 
                {
                    plateauWidth = Int32.Parse(userInput);
                }
                catch
                {
                    
                }
            }

            while (plateauHeight <= 1 || plateauHeight >= 100)
            {
                Console.WriteLine("Please provide an integer between 1 and 100, it will be the height of the plateau");

                string userInput = Console.ReadLine();
                try
                {
                    plateauHeight = Int32.Parse(userInput);
                }
                catch
                {

                }
            }


            while (roverXcoord <= 0 || roverXcoord > plateauHeight)
            {
                Console.WriteLine("Please provide an integer between 0 and  " + plateauHeight + ", it will be the starting x coordinate of the rover");

                string userInput = Console.ReadLine();
                try
                {
                    roverXcoord = Int32.Parse(userInput);
                }
                catch
                {

                }
            }

            while (roverYcoord <= 0 || roverYcoord > plateauWidth)
            {
                Console.WriteLine("Please provide an integer between 0 and  " + plateauWidth + ", it will be the starting y coordinate of the rover");

                string userInput = Console.ReadLine();
                try
                {
                    roverYcoord = Int32.Parse(userInput);
                }
                catch
                {

                }
            }

            while (heading != 'N' || heading != 'E' || heading != 'S' || heading != 'W')
            {
                Console.WriteLine("Please enter N, S, E, or W");

                string userInput = Console.ReadLine();

                try
                {
                    heading = Char.Parse(userInput);
                    break;
                }
                catch
                {

                }

            }

            while (IsValid(roverCommand) == false)
            {

                Console.WriteLine("Please enter a string consisting of L's R's and M's.");
                roverCommand = Console.ReadLine();

            }

            roverPosition = roverXcoord + " " + roverYcoord + " " + heading;
            Console.WriteLine("Creating a rover with position: " + roverPosition);
            Rover rover = new Rover(roverPosition);

            Console.WriteLine("Executing move with the directions: " + roverCommand);
            rover.MoveToLocation(roverCommand);

            if ( rover.xcoord > plateauWidth || rover.ycoord > plateauHeight || rover.xcoord < 0 || rover.ycoord < 0)
            {
                Console.WriteLine("The rover crashed. All of that money was wasted. Stay inside the grid next time...");
            }
            else
            {
                Console.WriteLine("Final output " + rover.xcoord + " " + rover.ycoord + " " + rover.heading);
            }
        }
    }
}
