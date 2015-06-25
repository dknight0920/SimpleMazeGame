using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeLib
{
    public class Player
    {
        private Room currentRoom;
        private Room finishRoom;

        public Player(Room startRoom, Room finishRoom)
        {
            this.currentRoom = startRoom;
            this.finishRoom = finishRoom;
        }

        public void Move(Room.directions direction)
        {
            currentRoom = currentRoom.GetSide(direction).Enter(this);
        }

        public Room GetCurrentRoom()
        {
            return currentRoom;
        }

        public bool hasFinished()
        {
            return currentRoom == finishRoom;
        }
    }
}
