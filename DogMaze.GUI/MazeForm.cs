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
        private Level level = null;
        private Player player;
        private Room.directions direction = Room.directions.east;
        private WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        private string soundUrl = @"Resources\Dog sound effect woof.mp3";

        public MazeForm()
        {  
            InitializeComponent();
            InitializeMazeLevel();
        }

        private void InitializeMazeLevel()
        {
            this.level = new LevelFactory().GetNextLevel(level);
            this.player = new Player(level.GetStartingRoom(), level.GetFinishingRoom());

            Draw(player.GetCurrentRoom());
            wplayer.URL = soundUrl;
            PlayDogBarkAudioClip();

            StopAllCurrentAnimation();
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
            StopAllCurrentAnimation();
            StartNewAnimation();
        }

        private void StartNewAnimation()
        {
            switch (direction)
            {
                case Room.directions.north:
                    this.DogRunningNorth.Image = global::DogMaze.GUI.Properties.Resources.MazeBackPlayerRunningNorth;
                    this.DogRunningNorth.Visible = true;
                    break;
                case Room.directions.east:
                    this.DogRunningEast.Image = global::DogMaze.GUI.Properties.Resources.MazeBackPlayerRunningEast;
                    this.DogRunningEast.Visible = true;
                    break;
                case Room.directions.south:
                    this.DogRunningSouth.Image = global::DogMaze.GUI.Properties.Resources.MazeBackPlayerRunningSouth;
                    this.DogRunningSouth.Visible = true;
                    break;
                case Room.directions.west:
                    this.DogRunningWest.Image = global::DogMaze.GUI.Properties.Resources.MazeBackPlayerRunningWest;
                    this.DogRunningWest.Visible = true;
                    break;
            }

            PlayAnimationFormTimerDuration();
        }

        private void PlayAnimationFormTimerDuration()
        {
            timer.Start();
        }

        private void timer_Tick(object sender, System.EventArgs e)
        {
            timer.Stop();
            StopAllCurrentAnimation();
            MovePlayer();
        }

        private void Draw(Room room)
        {
            DrawCenter();
            DrawNorthWall(room);
            DrawEastWall(room);
            DrawSouthWall(room);
            DrawWestWall(room);
        }

        private void DrawCenter()
        {
            if (player.hasFinished())
            {
                this.Dog.Image = global::DogMaze.GUI.Properties.Resources.MazeBackPlayerWinner;
                PlayDogBarkAudioClip();
                LoadNextLevel();
            }
            else
                this.Dog.Image = global::DogMaze.GUI.Properties.Resources.MazeBackPlayerStanding;
        }

        private void LoadNextLevel()
        {
            nextLevelTimer.Start(); 
        }

        private void nextLevelTimer_Tick(object sender, EventArgs e)
        {
            nextLevelTimer.Stop();
            InitializeMazeLevel();
        }

        private void DrawNorthWall(Room room)
        {
            bool hasNorthDoor = isDoor(room.GetSide(Room.directions.north));
            this.NorthWall.Image = (hasNorthDoor ? global::DogMaze.GUI.Properties.Resources.MazeBackGroundTopDoor : global::DogMaze.GUI.Properties.Resources.MazeBackGroundTopNoDoor);
        }

        private void DrawEastWall(Room room)
        {
            bool hasEastDoor = isDoor(room.GetSide(Room.directions.east));
            this.EastWall.Image = (hasEastDoor ? global::DogMaze.GUI.Properties.Resources.MazeBackGroundRightDoor : global::DogMaze.GUI.Properties.Resources.MazeBackGroundRightNoDoor);
        }

        private void DrawSouthWall(Room room)
        {
            bool hasSouthDoor = isDoor(room.GetSide(Room.directions.south));
            this.SouthWall.Image = (hasSouthDoor ? global::DogMaze.GUI.Properties.Resources.MazeBackGroundBottomDoor : global::DogMaze.GUI.Properties.Resources.MazeBackGroundBottomNoDoor);
        }

        private void DrawWestWall(Room room)
        {
            bool hasWestDoor = isDoor(room.GetSide(Room.directions.west));
            this.WestWall.Image = (hasWestDoor ? global::DogMaze.GUI.Properties.Resources.MazeBackGroundLeftDoor : global::DogMaze.GUI.Properties.Resources.MazeBackGroundLeftNoDoor);
        }

        private bool isDoor(MazeElement element)
        {
            return element.GetType() == typeof(Door);
        }

        private void StopAllCurrentAnimation()
        {
            this.DogRunningNorth.Visible = false;
            this.DogRunningEast.Visible = false;
            this.DogRunningSouth.Visible = false;
            this.DogRunningWest.Visible = false;
        }

        private void MovePlayer()
        {
            try
            {
                player.Move(direction);
            }
            catch
            {
                PlayDogBarkAudioClip();
            }
            
            Draw(player.GetCurrentRoom());
        }

        private void PlayDogBarkAudioClip()
        {
            wplayer.controls.play();
        }
    }
}
