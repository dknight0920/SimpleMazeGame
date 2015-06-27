using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeLib
{
    public sealed class MazeFactory
    {
        private static readonly Lazy<MazeFactory> lazyInstance = new Lazy<MazeFactory>(() => new MazeFactory());

        private MazeFactory()
        { 
        
        }

        public static MazeFactory Instance()
        {
            return lazyInstance.Value;
        }

        public Maze MakeMaze()
        {
            return new Maze();
        }

        public Wall MakeWall()
        {
            return new Wall();
        }

        public Room MakeRoom(int number)
        {
            return new Room(number);
        }

        public Door MakeDoor(Room room1, Room room2)
        {
            return new Door(room1, room2);
        }
    }
}
