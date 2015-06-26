using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeLib
{
    public class Level
    {
        private Maze maze;
        private Room startingRoom;
        private Room finishingRoom;

        public Level(Maze maze, Room startingRoom, Room finishingRoom)
        {
            this.maze = maze;
            this.startingRoom = startingRoom;
            this.finishingRoom = finishingRoom;
        }

        public Maze GetMaze()
        {
            return maze;
        }

        public Room GetStartingRoom()
        {
            return startingRoom;
        }

        public Room GetFinishingRoom()
        {
            return finishingRoom;
        }
    }
}
