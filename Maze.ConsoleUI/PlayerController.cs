using MazeLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Maze.ConsoleUI
{
    public class PlayerController
    {
        private Timer timer;
        private Player player;
        private RoomDrawer drawer;

        public PlayerController()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            InitLevel();
        }

        private void InitLevel()
        {
            var level = LevelFactory.Instance().GetLevel();
            this.player = new Player(level.GetStartingRoom(), level.GetFinishingRoom());
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

                if (player.hasFinished())
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    LoadNextLevel();
                }

                drawer.Draw(player.GetCurrentRoom());
                Console.Beep();
            }
            while (keyinfo.Key != ConsoleKey.Escape);

            Console.WriteLine("You have quit the game.");
        }

        private void LoadNextLevel()
        {
            this.timer = new System.Timers.Timer();
            timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Start();
        }

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            timer.Stop();
            this.timer.Enabled = false;
            InitLevel();
        }
    }
}
