using MazeLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new LevelFactory();

            var maze = factory.MakeLevelTwo();

            var player = new Player(maze.GetRoom(1), maze.GetRoom(9));

            new PlayerController(player).Start();
        }
    }
}
