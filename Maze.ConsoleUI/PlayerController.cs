using MazeLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze.ConsoleUI
{
    public class PlayerController
    {
        private Player player;
        private RoomDrawer drawer;

        public PlayerController(Player player)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            this.player = player;
            this.drawer = new RoomDrawer();
            drawer.Draw(player.GetCurrentRoom());
        }

        public void Start()
        {
            ConsoleKeyInfo keyinfo;
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                keyinfo = Console.ReadKey();
                try
                {
                    switch (keyinfo.Key)
                    {
                        case ConsoleKey.UpArrow:
                            player.Move(Room.directions.north);
                            drawer.Transition(Room.directions.north);
                            break;
                        case ConsoleKey.RightArrow:
                            player.Move(Room.directions.east);
                            drawer.Transition(Room.directions.east);
                            break;
                        case ConsoleKey.DownArrow:
                            player.Move(Room.directions.south);
                            drawer.Transition(Room.directions.south);
                            break;
                        case ConsoleKey.LeftArrow:
                            player.Move(Room.directions.west);
                            drawer.Transition(Room.directions.west);
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadLine();
                }

                if (player.hasFinished()) Console.ForegroundColor = ConsoleColor.Red;
                drawer.Draw(player.GetCurrentRoom());
                Console.Beep();
            }
            while (keyinfo.Key != ConsoleKey.Escape);

            Console.WriteLine("You have quit the game.");
        }
    }
}
