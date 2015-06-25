using MazeLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogMaze.GUI
{
    public partial class MazeForm : Form
    {
        private Player player;
        private Room.directions direction = Room.directions.east;
        private WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        private string soundUrl = @"c:\Users\Daniel\documents\visual studio 2013\Projects\Maze\DogMaze.GUI\Resources\Dog sound effect woof.mp3";
        public MazeForm()
        {  
            InitializeComponent();
            var factory = new LevelFactory();
            var maze = factory.MakeLevelTwo();
            this.player = new Player(maze.GetRoom(1), maze.GetRoom(9));
            Draw(player.GetCurrentRoom());
            wplayer.URL = soundUrl;
            wplayer.controls.play();

            this.DogRunningEast.Enabled = false;
            this.DogRunningEast.Visible = false;

            this.DogRunningWest.Enabled = false;
            this.DogRunningWest.Visible = false;

            this.DogRunningNorth.Enabled = false;
            this.DogRunningNorth.Visible = false;

            this.DogRunningSouth.Enabled = false;
            this.DogRunningSouth.Visible = false;
        }

        private void MazeForm_Load(object sender, EventArgs e)
        {
            
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Up:
                    direction = Room.directions.north;
                    break;
                case Keys.Right:
                    direction = Room.directions.east;
                    break;
                case Keys.Down:
                    direction = Room.directions.south;
                    break;
                case Keys.Left:
                    direction = Room.directions.west;
                    break;
            }

            AnimatePlayer();

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void AnimatePlayer()
        {
                switch (direction)
                {
                    case Room.directions.north:
                        this.DogRunningNorth.Image = global::DogMaze.GUI.Properties.Resources.MazeBackPlayerRunningNorth;
                        this.DogRunningNorth.Enabled = true;
                        this.DogRunningNorth.Visible = true;
                        NorthTimer.Start();
                        break;
                    case Room.directions.east:

                        this.DogRunningEast.Image = global::DogMaze.GUI.Properties.Resources.MazeBackPlayerRunningEast;
                        this.DogRunningEast.Enabled = true;
                        this.DogRunningEast.Visible = true;
                        EastTimer.Start();
                        break;
                    case Room.directions.south:
                        this.DogRunningSouth.Image = global::DogMaze.GUI.Properties.Resources.MazeBackPlayerRunningSouth;
                        this.DogRunningSouth.Enabled = true;
                        this.DogRunningSouth.Visible = true;
                        SouthTimer.Start();
                        break;
                    case Room.directions.west:
                        this.DogRunningWest.Image = global::DogMaze.GUI.Properties.Resources.MazeBackPlayerRunningWest;
                        this.DogRunningWest.Enabled = true;
                        this.DogRunningWest.Visible = true;
                        WestTimer.Start();
                        break;
                }                      
        }

        private void Draw(Room room)
        {
            if (player.hasFinished())
            {
                this.Dog.Image = global::DogMaze.GUI.Properties.Resources.MazeBackPlayerWinner;
                wplayer.controls.play();
            }
            else
                this.Dog.Image = global::DogMaze.GUI.Properties.Resources.MazeBackPlayerStanding;

            bool hasNorthDoor = room.GetSide(Room.directions.north).GetType() == typeof(Door);
            this.NorthWall.Image = (hasNorthDoor ? global::DogMaze.GUI.Properties.Resources.MazeBackGroundTopDoor : global::DogMaze.GUI.Properties.Resources.MazeBackGroundTopNoDoor);

            bool hasEastDoor = room.GetSide(Room.directions.east).GetType() == typeof(Door);
            this.EastWall.Image = (hasEastDoor ? global::DogMaze.GUI.Properties.Resources.MazeBackGroundRightDoor : global::DogMaze.GUI.Properties.Resources.MazeBackGroundRightNoDoor);

            bool hasSouthDoor = room.GetSide(Room.directions.south).GetType() == typeof(Door);
            this.SouthWall.Image = (hasSouthDoor ? global::DogMaze.GUI.Properties.Resources.MazeBackGroundBottomDoor : global::DogMaze.GUI.Properties.Resources.MazeBackGroundBottomNoDoor);

            bool hasWestDoor = room.GetSide(Room.directions.west).GetType() == typeof(Door);
            this.WestWall.Image = (hasWestDoor ? global::DogMaze.GUI.Properties.Resources.MazeBackGroundLeftDoor : global::DogMaze.GUI.Properties.Resources.MazeBackGroundLeftNoDoor);
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            EastTimer.Stop();
            this.DogRunningEast.Enabled = false;
            this.DogRunningEast.Visible = false;
            MovePlayer();
        }



        private void timer2_Tick(object sender, EventArgs e)
        {
            WestTimer.Stop();
            this.DogRunningWest.Enabled = false;
            this.DogRunningWest.Visible = false;
            MovePlayer();
        }

        private void NorthTimer_Tick(object sender, EventArgs e)
        {
            NorthTimer.Stop();
            this.DogRunningNorth.Enabled = false;
            this.DogRunningNorth.Visible = false;
            MovePlayer();
        }

        private void SouthTimer_Tick(object sender, EventArgs e)
        {
            SouthTimer.Stop();
            this.DogRunningSouth.Enabled = false;
            this.DogRunningSouth.Visible = false;
            MovePlayer();
        }

        private void MovePlayer()
        {
            try
            {
                player.Move(direction);
            }
            catch
            {
                wplayer.controls.play();
            }
            
            Draw(player.GetCurrentRoom());
        }

    }
}
