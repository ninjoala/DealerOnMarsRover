using System;
using System.Collections.Generic;
using System.Text;

namespace DealerOnMarsRover
{
    public class Rover
    {
        public int xcoord; // x coordinate
        public int ycoord; // y coordinate
        public char heading; // direction rover is facing
        public static char north = 'N';
        public static char south = 'S';
        public static char east = 'E';
        public static char west = 'W';


        public Rover(string roverStartingLocation)
        {
            var roverData = roverStartingLocation.Split(" ");
            Int32.TryParse(roverData[0], out xcoord);
            Int32.TryParse(roverData[1], out ycoord);

            heading = Char.Parse(roverData[2]);
        }

        public void TurnLeft()
        {
            switch (heading)
            {
                case 'N':
                    heading = west;
                    break;

                case 'W':
                    heading = south;
                    break;

                case 'S':
                    heading = east;
                    break;

                case 'E':
                    heading = north;
                    break;

                default:
                    throw new ArgumentException();
            }
        }

        public void TurnRight()
        {
            switch (heading)
            {
                case 'N':
                    heading = east;
                    break;

                case 'W':
                    heading = north;
                    break;

                case 'S':
                    heading = west;
                    break;

                case 'E':
                    heading = south;
                    break;

                default:
                    throw new ArgumentException();
            }
        }
        public void MoveForward()
        {
            switch (heading)
            {
                case 'N':
                    ycoord += 1;
                    break;

                case 'W':
                    xcoord -= 1;
                    break;

                case 'S':
                    ycoord -= 1;
                    break;

                case 'E':
                    xcoord += 1;
                    break;

                default:
                    throw new ArgumentException();
            }
        }
        public void MoveToLocation(string roverCommand) // LMLMLMLMM or MMRMMRMRRM
        {
            char[] instructions = roverCommand.ToCharArray();

            for (int currentInstruction = 0; currentInstruction < instructions.Length; currentInstruction++)
            {
                switch (instructions[currentInstruction])
                {
                    case 'L':
                        TurnLeft();
                        break;

                    case 'R':
                        TurnRight();
                        break;

                    case 'M':
                        MoveForward();
                        break;

                    default:
                        throw new ArgumentException();
                }

            }

        }
    }
}

