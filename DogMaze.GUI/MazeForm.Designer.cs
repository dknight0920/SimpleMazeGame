using System.Drawing;
namespace DogMaze.GUI
{
    partial class MazeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.DogRunningSouth = new System.Windows.Forms.PictureBox();
            this.DogRunningNorth = new System.Windows.Forms.PictureBox();
            this.DogRunningWest = new System.Windows.Forms.PictureBox();
            this.DogRunningEast = new System.Windows.Forms.PictureBox();
            this.Dog = new System.Windows.Forms.PictureBox();
            this.WestWall = new System.Windows.Forms.PictureBox();
            this.SouthWall = new System.Windows.Forms.PictureBox();
            this.NorthWall = new System.Windows.Forms.PictureBox();
            this.EastWall = new System.Windows.Forms.PictureBox();
            this.nextLevelTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DogRunningSouth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DogRunningNorth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DogRunningWest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DogRunningEast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WestWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SouthWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NorthWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EastWall)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 700;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // DogRunningSouth
            // 
            this.DogRunningSouth.Image = global::DogMaze.GUI.Properties.Resources.MazeBackPlayerRunningSouth;
            this.DogRunningSouth.Location = new System.Drawing.Point(123, 121);
            this.DogRunningSouth.Name = "DogRunningSouth";
            this.DogRunningSouth.Size = new System.Drawing.Size(599, 596);
            this.DogRunningSouth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DogRunningSouth.TabIndex = 8;
            this.DogRunningSouth.TabStop = false;
            // 
            // DogRunningNorth
            // 
            this.DogRunningNorth.Image = global::DogMaze.GUI.Properties.Resources.MazeBackPlayerRunningNorth;
            this.DogRunningNorth.Location = new System.Drawing.Point(123, 121);
            this.DogRunningNorth.Name = "DogRunningNorth";
            this.DogRunningNorth.Size = new System.Drawing.Size(599, 596);
            this.DogRunningNorth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DogRunningNorth.TabIndex = 7;
            this.DogRunningNorth.TabStop = false;
            // 
            // DogRunningWest
            // 
            this.DogRunningWest.Image = global::DogMaze.GUI.Properties.Resources.MazeBackPlayerRunningWest;
            this.DogRunningWest.Location = new System.Drawing.Point(123, 121);
            this.DogRunningWest.Name = "DogRunningWest";
            this.DogRunningWest.Size = new System.Drawing.Size(599, 596);
            this.DogRunningWest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DogRunningWest.TabIndex = 6;
            this.DogRunningWest.TabStop = false;
            // 
            // DogRunningEast
            // 
            this.DogRunningEast.Image = global::DogMaze.GUI.Properties.Resources.MazeBackPlayerRunningEast;
            this.DogRunningEast.Location = new System.Drawing.Point(123, 121);
            this.DogRunningEast.Name = "DogRunningEast";
            this.DogRunningEast.Size = new System.Drawing.Size(599, 596);
            this.DogRunningEast.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DogRunningEast.TabIndex = 5;
            this.DogRunningEast.TabStop = false;
            // 
            // Dog
            // 
            this.Dog.Image = global::DogMaze.GUI.Properties.Resources.MazeBackPlayerStanding;
            this.Dog.Location = new System.Drawing.Point(123, 121);
            this.Dog.Name = "Dog";
            this.Dog.Size = new System.Drawing.Size(599, 596);
            this.Dog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dog.TabIndex = 3;
            this.Dog.TabStop = false;
            // 
            // WestWall
            // 
            this.WestWall.Image = global::DogMaze.GUI.Properties.Resources.MazeBackGroundLeftDoor;
            this.WestWall.Location = new System.Drawing.Point(2, 208);
            this.WestWall.Name = "WestWall";
            this.WestWall.Size = new System.Drawing.Size(210, 420);
            this.WestWall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.WestWall.TabIndex = 2;
            this.WestWall.TabStop = false;
            // 
            // SouthWall
            // 
            this.SouthWall.Image = global::DogMaze.GUI.Properties.Resources.MazeBackGroundBottomDoor;
            this.SouthWall.Location = new System.Drawing.Point(2, 625);
            this.SouthWall.Name = "SouthWall";
            this.SouthWall.Size = new System.Drawing.Size(840, 212);
            this.SouthWall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.SouthWall.TabIndex = 1;
            this.SouthWall.TabStop = false;
            // 
            // NorthWall
            // 
            this.NorthWall.Image = global::DogMaze.GUI.Properties.Resources.MazeBackGroundTopDoor;
            this.NorthWall.Location = new System.Drawing.Point(2, 2);
            this.NorthWall.Name = "NorthWall";
            this.NorthWall.Size = new System.Drawing.Size(840, 212);
            this.NorthWall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.NorthWall.TabIndex = 0;
            this.NorthWall.TabStop = false;
            // 
            // EastWall
            // 
            this.EastWall.Image = global::DogMaze.GUI.Properties.Resources.MazeBackGroundRightDoor;
            this.EastWall.Location = new System.Drawing.Point(632, 208);
            this.EastWall.Name = "EastWall";
            this.EastWall.Size = new System.Drawing.Size(210, 420);
            this.EastWall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.EastWall.TabIndex = 4;
            this.EastWall.TabStop = false;
            // 
            // nextLevelTimer
            // 
            this.nextLevelTimer.Interval = 2000;
            this.nextLevelTimer.Tick += new System.EventHandler(this.nextLevelTimer_Tick);
            // 
            // MazeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 839);
            this.Controls.Add(this.DogRunningSouth);
            this.Controls.Add(this.DogRunningNorth);
            this.Controls.Add(this.DogRunningWest);
            this.Controls.Add(this.DogRunningEast);
            this.Controls.Add(this.Dog);
            this.Controls.Add(this.WestWall);
            this.Controls.Add(this.SouthWall);
            this.Controls.Add(this.NorthWall);
            this.Controls.Add(this.EastWall);
            this.Name = "MazeForm";
            this.Text = "Dog Maze";
            ((System.ComponentModel.ISupportInitialize)(this.DogRunningSouth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DogRunningNorth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DogRunningWest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DogRunningEast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WestWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SouthWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NorthWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EastWall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox NorthWall;
        private System.Windows.Forms.PictureBox SouthWall;
        private System.Windows.Forms.PictureBox WestWall;
        private System.Windows.Forms.PictureBox Dog;
        private System.Windows.Forms.PictureBox EastWall;
        private System.Windows.Forms.PictureBox DogRunningEast;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox DogRunningWest;
        private System.Windows.Forms.PictureBox DogRunningNorth;
        private System.Windows.Forms.PictureBox DogRunningSouth;
        private System.Windows.Forms.Timer nextLevelTimer;
    }
}

