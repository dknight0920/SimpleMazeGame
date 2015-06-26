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
        Func<Level> next;

        public Level(Maze maze, Room startingRoom, Room finishingRoom, Func<Level> next)
        {
            this.maze = maze;
            this.startingRoom = startingRoom;
            this.finishingRoom = finishingRoom;
            this.next = next;
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

        public Level Next()
        {
            return next();
        }
    }
}
