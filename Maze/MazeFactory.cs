using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeLib
{
    public class MazeFactory
    {
        private static MazeFactory instance = null;

        protected MazeFactory()
        { 
        
        }

        public static MazeFactory Instance()
        {
            if (instance == null) instance = new MazeFactory();
            return instance;
        }

        public virtual Maze MakeMaze()
        {
            return new Maze();
        }

        public virtual Wall MakeWall()
        {
            return new Wall();
        }

        public virtual Room MakeRoom(int number)
        {
            return new Room(number);
        }

        public virtual Door MakeDoor(Room room1, Room room2)
        {
            return new Door(room1, room2);
        }
    }
}
