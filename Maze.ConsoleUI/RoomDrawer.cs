using MazeLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze.ConsoleUI
{
    public class RoomDrawer
    {
        public void Draw(Room room)
        {
            Console.Clear();
            Console.SetCursorPosition(0, Console.CursorTop);

            bool hasNorthDoor = room.GetSide(Room.directions.north).GetType() == typeof(Door);
            string northSegment = (hasNorthDoor ? "|               |" : ". . . . . . . . .");

            bool hasEastDoor = room.GetSide(Room.directions.east).GetType() == typeof(Door);
            string eastSegment1 = (hasEastDoor ? "--" : ".");
            string eastSegment2 = (hasEastDoor ? " " : ".");

            bool hasSouthDoor = room.GetSide(Room.directions.south).GetType() == typeof(Door);
            string southSegment = (hasSouthDoor ? "|               |" : ". . . . . . . . .");

            bool hasWestDoor = room.GetSide(Room.directions.west).GetType() == typeof(Door);
            string westSegment1 = (hasWestDoor ? "--" : " .");
            string westSegment2 = (hasWestDoor ? "  " : " .");

            Console.WriteLine(             " . . . . . . . . . . . " + northSegment + " . . . . . . . . . . . .");
            Console.WriteLine(             " .                                                             .");
            Console.WriteLine(             " .                                                             .");
            Console.WriteLine(             " .                                                             .");
            Console.WriteLine(             " .                                                             .");
            Console.WriteLine(             " .                                                             .");
            Console.WriteLine(             " .                           .....                             .");
            Console.WriteLine(westSegment1 + "                           |   |                             " + eastSegment1);
            Console.WriteLine(westSegment2 + "                           .....                             " + eastSegment2);
            Console.WriteLine(westSegment2 + "                             .                               " + eastSegment2);
            Console.WriteLine(westSegment2 + "                             .                               " + eastSegment2);
            Console.WriteLine(westSegment2 + "                           . . .                             " + eastSegment2);
            Console.WriteLine(westSegment2 + "                        . .  .  . .                          " + eastSegment2);
            Console.WriteLine(westSegment2 + "                             .                               " + eastSegment2);
            Console.WriteLine(westSegment2 + "                            . .                              " + eastSegment2);
            Console.WriteLine(westSegment2 + "                           .   .                             " + eastSegment2);
            Console.WriteLine(westSegment1 + "                          .     .                            " + eastSegment1);
            Console.WriteLine(             " .                       ...       ...                         .");
            Console.WriteLine(             " .                                                             .");
            Console.WriteLine(             " .                                                             .");
            Console.WriteLine(             " .                                                             .");
            Console.WriteLine(             " .                                                             .");
            Console.WriteLine(             " .                                                             .");
            Console.WriteLine(             " . . . . . . . . . . . " + southSegment + " . . . . . . . . . . . .");
        }

        public void Transition(Room.directions direction)
        {
            Console.Clear();
            Console.SetCursorPosition(0, Console.CursorTop);

            bool moveNorth = direction == Room.directions.north;
            bool moveEast = direction == Room.directions.east;
            bool moveSouth = direction == Room.directions.south;
            bool moveWest = direction == Room.directions.west;

            if (moveSouth)
            {
                Console.WriteLine(" ");
                Console.WriteLine("                                                                ");
                Console.WriteLine("                             .....                              ");
                Console.WriteLine("                             |   |                              ");
                Console.WriteLine("                             .....                              ");
                Console.WriteLine("                               .                                ");
                Console.WriteLine("                               .                                ");
                Console.WriteLine("                             . . .                              ");
                Console.WriteLine("                          . .  .  . .                           ");
                Console.WriteLine("                               .                                ");
                Console.WriteLine("                              . .                               ");
                Console.WriteLine("                             .   .                              ");
                Console.WriteLine("                            .     .                             ");
                Console.WriteLine("                         ...       ...                          ");
                Console.WriteLine("                                                                ");
                Console.WriteLine("                                                                ");
                Console.WriteLine("                                                                ");
                Console.WriteLine("                                                                ");
                Console.WriteLine("                                                                ");
                Console.WriteLine("                                                                ");
                Console.WriteLine("                                                                ");
                Console.WriteLine("                                                                ");
                Console.WriteLine("                                                                ");
                Console.WriteLine(" ");
            }
            else if (moveWest)
            {
                Console.WriteLine(" ");
                Console.WriteLine("                                                                ");
                Console.WriteLine("                                                                ");
                Console.WriteLine("                                                                ");
                Console.WriteLine("                                                                ");
                Console.WriteLine("                                                                ");
                Console.WriteLine("                                          .....                 ");
                Console.WriteLine("                                          |   |                 ");
                Console.WriteLine("                                          .....                 ");
                Console.WriteLine("                                            .                   ");
                Console.WriteLine("                                            .                   ");
                Console.WriteLine("                                          . . .                 ");
                Console.WriteLine("                                       . .  .  . .              ");
                Console.WriteLine("                                            .                   ");
                Console.WriteLine("                                           . .                  ");
                Console.WriteLine("                                          .   .                 ");
                Console.WriteLine("                                         .     .                ");
                Console.WriteLine("                                      ...       ...             ");
                Console.WriteLine("                                                                ");
                Console.WriteLine("                                                                ");
                Console.WriteLine("                                                                ");
                Console.WriteLine("                                                                ");
                Console.WriteLine("                                                                ");
                Console.WriteLine(" ");
            }
            else if (moveNorth)
            {
                Console.WriteLine(" ");
                Console.WriteLine("                                                                ");
                Console.WriteLine("                                                                ");
                Console.WriteLine("                                                                ");
                Console.WriteLine("                                                                ");
                Console.WriteLine("                                                                ");
                Console.WriteLine("                                                                ");
                Console.WriteLine("                                                                ");
                Console.WriteLine("                                                                ");
                Console.WriteLine("                                                                ");
                Console.WriteLine("                             .....                              ");
                Console.WriteLine("                             |   |                              ");
                Console.WriteLine("                             .....                              ");
                Console.WriteLine("                               .                                ");
                Console.WriteLine("                               .                                ");
                Console.WriteLine("                             . . .                              ");
                Console.WriteLine("                          . .  .  . .                           ");
                Console.WriteLine("                               .                                ");
                Console.WriteLine("                              . .                               ");
                Console.WriteLine("                             .   .                              ");
                Console.WriteLine("                            .     .                             ");
                Console.WriteLine("                         ...       ...                          ");
                Console.WriteLine("                                                                ");
                Console.WriteLine(" ");
            }
            else if (moveEast)
            {
                Console.WriteLine(" ");
                Console.WriteLine("                                                                ");
                Console.WriteLine("                                                                ");
                Console.WriteLine("                                                                ");
                Console.WriteLine("                                                                ");
                Console.WriteLine("                                                                ");
                Console.WriteLine("                 .....                                          ");
                Console.WriteLine("                 |   |                                          ");
                Console.WriteLine("                 .....                                          ");
                Console.WriteLine("                   .                                            ");
                Console.WriteLine("                   .                                            ");
                Console.WriteLine("                 . . .                                          ");
                Console.WriteLine("              . .  .  . .                                       ");
                Console.WriteLine("                   .                                            ");
                Console.WriteLine("                  . .                                           ");
                Console.WriteLine("                 .   .                                          ");
                Console.WriteLine("                .     .                                         ");
                Console.WriteLine("             ...       ...                                      ");
                Console.WriteLine("                                                                ");
                Console.WriteLine("                                                                ");
                Console.WriteLine("                                                                ");
                Console.WriteLine("                                                                ");
                Console.WriteLine("                                                                ");
                Console.WriteLine(" ");
            }

            System.Threading.Thread.Sleep(100);
        }
    }
}
