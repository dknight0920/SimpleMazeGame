using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MazeLib
{
    public class Maze
    {
        private List<Room> rooms;

        public Maze()
        {
            rooms = new List<Room>();
        }

        public void AddRoom(Room room)
        {
            rooms.Add(room);
        }

        public Room GetRoom(int number)
        {
            foreach (var room in rooms)
            {
                if (room.GetRoomNumber() == number) return room;
            }

            throw new Exception("Room: " + number + " does not exist in the maze.");
        }
    }
}
