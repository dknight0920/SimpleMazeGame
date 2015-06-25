using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MazeLib
{
    public class Room
    {
        private int roomNumber;

        private MazeElement northWall;
        private MazeElement eastWall;
        private MazeElement southWall;
        private MazeElement westWall;

        public enum directions { north, east, south, west };

        public Room(int number)
        {
            roomNumber = number;
        }

        public int GetRoomNumber()
        {
            return roomNumber;
        }

        public void SetSide(directions side, MazeElement element)
        {
            switch (side)
            {
                case directions.north:
                    northWall = element;
                    break;
                case directions.east:
                    eastWall = element;
                    break;
                case directions.south:
                    southWall = element;
                    break;
                case directions.west:
                    westWall = element;
                    break;
            }
        }

        public MazeElement GetSide(directions side)
        {
            switch (side)
            {
                case directions.north:
                    return northWall;
                  case directions.east:
                    return eastWall;
                case directions.south:
                    return southWall;
                case directions.west:
                    return westWall;
            }

            return northWall;
        }
    }
}
