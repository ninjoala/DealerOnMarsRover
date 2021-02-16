using System;
using Xunit;
using DealerOnMarsRover;

namespace MarsRoverTests
{
    public class RoverShould
    {
        [Fact]
        public void TurnLeftStartNorth()
        {
            Rover rover = new Rover("1 2 N");

            //act
            rover.TurnLeft();
            //assert
            Assert.True(rover.heading == 'W');
        }
        [Fact]
        public void TurnLeftStartSouth()
        {
            Rover rover = new Rover("1 2 S");

            //act
            rover.TurnLeft();
            //assert
            Assert.True(rover.heading == 'E');
        }
        [Fact]
        public void TurnLeftStartWest()
        {
            Rover rover = new Rover("1 2 W");

            //act
            rover.TurnLeft();
            //assert
            Assert.True(rover.heading == 'S');
        }
        [Fact]
        public void TurnLeftStartEast()
        {
            Rover rover = new Rover("1 2 E");

            //act
            rover.TurnLeft();
            //assert
            Assert.True(rover.heading == 'N');
        }

        [Fact]
        public void TurnRightStartNorth()
        {
            Rover rover = new Rover("1 2 N");

            //act
            rover.TurnRight();
            //assert
            Assert.True(rover.heading == 'E');
        }
        [Fact]
        public void TurnRightStartSouth()
        {
            Rover rover = new Rover("1 2 S");

            //act
            rover.TurnRight();
            //assert
            Assert.True(rover.heading == 'W');
        }
        [Fact]
        public void TurnRightStartEast()
        {
            Rover rover = new Rover("1 2 E");

            //act
            rover.TurnRight();
            //assert
            Assert.True(rover.heading == 'S');
        }
        [Fact]
        public void TurnRightStartWest()
        {
            Rover rover = new Rover("1 2 W");

            //act
            rover.TurnRight();
            //assert
            Assert.True(rover.heading == 'N');
        }

        [Fact]
        public void MoveForwardStartNorth()
        {
            Rover rover = new Rover("1 2 N");

            //act
            rover.MoveForward();
            //assert
            Assert.Equal(3, rover.ycoord);
        }
        [Fact]
        public void MoveForwardStartSouth()
        {
            Rover rover = new Rover("1 2 S");

            //act
            rover.MoveForward();
            //assert
            Assert.Equal(1, rover.ycoord);
        }
        [Fact]
        public void MoveForwardStartWest()
        {
            Rover rover = new Rover("1 2 W");

            //act
            rover.MoveForward();
            //assert
            Assert.Equal(0, rover.xcoord);
        }
        [Fact]
        public void MoveForwardStartEast()
        {
            Rover rover = new Rover("1 2 E");

            //act
            rover.MoveForward();
            //assert
            Assert.Equal(2, rover.xcoord);
        }

        [Fact]
        public void GoTo1_3_N()
        {
            Rover rover = new Rover("1 2 N");

            //act
            rover.MoveToLocation("LMLMLMLMM");
            //assert
            Assert.Equal("1 3 N", rover.xcoord + " " + rover.ycoord + " " + rover.heading);
        }

        [Fact]
        public void GoTo5_1_E()
        {
            Rover rover = new Rover("3 3 E");

            //act
            rover.MoveToLocation("MMRMMRMRRM");
            //assert
            Assert.Equal("5 1 E", rover.xcoord + " " + rover.ycoord + " " + rover.heading);
        }
    }
}
