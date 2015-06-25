using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MazeLib
{
    public class Door : MazeElement
    {
        private bool open;
        private Room room1;
        private Room room2;

        public Door(Room room1, Room room2)
        {
            this.room1 = room1;
            this.room2 = room2;
            OpenDoor();
        }

        public void CloseDoor()
        {
            open = false;
        }

        public void OpenDoor()
        {
            open = true;
        }

        public override Room Enter(Player player)
        {
            if (!open) throw new Exception("The door is closed. Muhaha!");

            if (player.GetCurrentRoom().GetRoomNumber() == room1.GetRoomNumber())
                return room2;
            else
                return room1;
        }

        public bool isOpen()
        {
            return open;
        }
    }
}
