using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeLib
{
    public class LevelFactory
    {
        public Maze MakeLevelOne()
        {
            var factory = new MazeFactory();

            var maze = factory.MakeMaze();

            var room1 = factory.MakeRoom(1);
            var room2 = factory.MakeRoom(2);
            var room3 = factory.MakeRoom(3);
            var room4 = factory.MakeRoom(4);

            var door1 = factory.MakeDoor(room1, room2);
            var door2 = factory.MakeDoor(room1, room3);
            var door3 = factory.MakeDoor(room2, room4);

            room1.SetSide(Room.directions.north, door1);
            room1.SetSide(Room.directions.east, door2);
            room1.SetSide(Room.directions.south, factory.MakeWall());
            room1.SetSide(Room.directions.west, factory.MakeWall());

            room2.SetSide(Room.directions.north, factory.MakeWall());
            room2.SetSide(Room.directions.east, door3);
            room2.SetSide(Room.directions.south, door1);
            room2.SetSide(Room.directions.west, factory.MakeWall());

            room3.SetSide(Room.directions.north, factory.MakeWall());
            room3.SetSide(Room.directions.east, factory.MakeWall());
            room3.SetSide(Room.directions.south, factory.MakeWall());
            room3.SetSide(Room.directions.west, door2);

            room4.SetSide(Room.directions.north, factory.MakeWall());
            room4.SetSide(Room.directions.east, factory.MakeWall());
            room4.SetSide(Room.directions.south, factory.MakeWall());
            room4.SetSide(Room.directions.west, door3);

            maze.AddRoom(room1);
            maze.AddRoom(room2);
            maze.AddRoom(room3);
            maze.AddRoom(room4);

            return maze;
        }

        public Maze MakeLevelTwo()
        {
            var factory = new MazeFactory();

            var maze = factory.MakeMaze();

            var room1 = factory.MakeRoom(1);
            var room2 = factory.MakeRoom(2);
            var room3 = factory.MakeRoom(3);
            var room4 = factory.MakeRoom(4);
            var room5 = factory.MakeRoom(5);
            var room6 = factory.MakeRoom(6);
            var room7 = factory.MakeRoom(7);
            var room8 = factory.MakeRoom(8);
            var room9 = factory.MakeRoom(9);
            var room10 = factory.MakeRoom(10);
            var room11 = factory.MakeRoom(11);

            var door1 = factory.MakeDoor(room1, room2);
            var door2 = factory.MakeDoor(room1, room3);
            var door3 = factory.MakeDoor(room2, room4);
            var door4 = factory.MakeDoor(room4, room5);
            var door5 = factory.MakeDoor(room5, room6);
            var door6 = factory.MakeDoor(room6, room7);
            var door7 = factory.MakeDoor(room7, room8);
            var door8 = factory.MakeDoor(room7, room9);
            var door9 = factory.MakeDoor(room6, room10);
            var door10 = factory.MakeDoor(room5, room11);

            room1.SetSide(Room.directions.north, door1);
            room1.SetSide(Room.directions.east, door2);
            room1.SetSide(Room.directions.south, factory.MakeWall());
            room1.SetSide(Room.directions.west, factory.MakeWall());

            room2.SetSide(Room.directions.north, factory.MakeWall());
            room2.SetSide(Room.directions.east, door3);
            room2.SetSide(Room.directions.south, door1);
            room2.SetSide(Room.directions.west, factory.MakeWall());

            room3.SetSide(Room.directions.north, factory.MakeWall());
            room3.SetSide(Room.directions.east, factory.MakeWall());
            room3.SetSide(Room.directions.south, factory.MakeWall());
            room3.SetSide(Room.directions.west, door2);

            room4.SetSide(Room.directions.north, factory.MakeWall());
            room4.SetSide(Room.directions.east, factory.MakeWall());
            room4.SetSide(Room.directions.south, door4);
            room4.SetSide(Room.directions.west, door3);

            room5.SetSide(Room.directions.north, door4);
            room5.SetSide(Room.directions.east, door5);
            room5.SetSide(Room.directions.south, factory.MakeWall());
            room5.SetSide(Room.directions.west, door10);

            room6.SetSide(Room.directions.north, door9);
            room6.SetSide(Room.directions.east, factory.MakeWall());
            room6.SetSide(Room.directions.south, door6);
            room6.SetSide(Room.directions.west, door5);

            room7.SetSide(Room.directions.north, door6);
            room7.SetSide(Room.directions.east, door8);
            room7.SetSide(Room.directions.south, factory.MakeWall());
            room7.SetSide(Room.directions.west, door7);

            room8.SetSide(Room.directions.north, factory.MakeWall());
            room8.SetSide(Room.directions.east, door7);
            room8.SetSide(Room.directions.south, factory.MakeWall());
            room8.SetSide(Room.directions.west, factory.MakeWall());

            room9.SetSide(Room.directions.north, factory.MakeWall());
            room9.SetSide(Room.directions.east, factory.MakeWall());
            room9.SetSide(Room.directions.south, factory.MakeWall());
            room9.SetSide(Room.directions.west, door8);

            room10.SetSide(Room.directions.north, factory.MakeWall());
            room10.SetSide(Room.directions.east, factory.MakeWall());
            room10.SetSide(Room.directions.south, door9);
            room10.SetSide(Room.directions.west, factory.MakeWall());

            room11.SetSide(Room.directions.north, factory.MakeWall());
            room11.SetSide(Room.directions.east, door10);
            room11.SetSide(Room.directions.south, factory.MakeWall());
            room11.SetSide(Room.directions.west, factory.MakeWall());

            maze.AddRoom(room1);
            maze.AddRoom(room2);
            maze.AddRoom(room3);
            maze.AddRoom(room4);
            maze.AddRoom(room5);
            maze.AddRoom(room6);
            maze.AddRoom(room7);
            maze.AddRoom(room8);
            maze.AddRoom(room9);
            maze.AddRoom(room10);
            maze.AddRoom(room11);

            return maze;
        }
    }
}
