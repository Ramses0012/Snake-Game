using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA5_Draft
{
    public partial class MainForm : Form
    {
        private readonly System.Media.SoundPlayer eatSoundPlayer;
        private readonly System.Media.SoundPlayer wallSoundPlayer;
        private readonly System.Media.SoundPlayer snakeSoundPlayer;
        private int applesEaten = 0;
        private bool isGameLost = false;
        private int Step = 1;
        private readonly SnakeGame Game;
        public int NumberOfApples;

        public MainForm()
        {
            ChooseNumberOfApplesForm dialogue = new ChooseNumberOfApplesForm();
            DialogResult res = dialogue.ShowDialog();
            NumberOfApples = dialogue.numberOfApples;

            InitializeComponent();
            
            Game = new SnakeGame(new System.Drawing.Point((Field.Width - 20) / 2, Field.Height / 2), 40, NumberOfApples, Field.Size);
            Field.Image = new Bitmap(Field.Width, Field.Height);
            Game.EatAndGrow += Game_EatAndGrow;
            Game.HitWallAndLose += Game_HitWallAndLose;
            Game.HitSnakeAndLose += Game_HitSnakeAndLose;
            /*Example of Game_EatAndGrow Sound Code.*/ eatSoundPlayer = new System.Media.SoundPlayer("C:\\Users\\ranse\\Downloads\\eat.wav"); // Remember!!! This is just and example I used. Replace "eat.wav" with the path to your eat sound file
            /*Example of HitWallAndLose Sound Code.*/ wallSoundPlayer = new System.Media.SoundPlayer("C:\\Users\\ranse\\Downloads\\wall.wav"); // Remember!!! This is just and example I used. Replace "wall.wav" with the path to your wall sound file
            /*Example of HitSnakeAndLose Sound Code.*/ snakeSoundPlayer = new System.Media.SoundPlayer("C:\\Users\\ranse\\Downloads\\snake.wav"); // Remember!!! This is just and example I used. Replace "snake.wav" with the path to your snake sound file
        }

        private void Game_HitWallAndLose()
        {
            mainTimer.Stop();
            Field.Refresh();
            isGameLost = true;
          //  wallSoundPlayer.Play();

        }
        private void Game_HitSnakeAndLose()
        {
            mainTimer.Stop();
            Field.Refresh();
            isGameLost = true;
          //  snakeSoundPlayer.Play();

        }

        private void Game_EatAndGrow()
        {
            applesEaten++;
            if (applesEaten % 10 == 0 && Step < 10)
            {
                Step++;
                progressBar1.Value = Step;
            }
            // eatSoundPlayer.Play();
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            if (!isGameLost)
            {
                Game.Move(Step);

                Field.Invalidate();
            }
        }

        private void Field_Paint(object sender, PaintEventArgs e)
        {                                
                Pen PenForObstacles = new Pen(Color.FromArgb(40, 40, 40), 2);
                Pen PenForSnake = new Pen(Color.FromArgb(100, 100, 100), 2);
                Brush BackGroundBrush = new SolidBrush(Color.FromArgb(150, 250, 150));
                Brush AppleBrush = new SolidBrush(Color.FromArgb(250, 50, 50));
                string message = $"Game Over! You ate {Game.EatenApples} apple(s).";
                bool showApples = DateTime.Now.Millisecond < 500;
                using (Graphics g = Graphics.FromImage(Field.Image))
                using (Font font = new Font("Arial", 20, FontStyle.Bold))
                {
                    if (isGameLost)
                    {
                        SizeF messageSize = e.Graphics.MeasureString(message, font);
                        PointF messageLocation = new PointF((Field.Width - messageSize.Width) / 2, (Field.Height - messageSize.Height) / 2);
                        e.Graphics.DrawString(message, font, Brushes.Black, messageLocation);
                    }

                        g.FillRectangle(BackGroundBrush, new Rectangle(0, 0, Field.Width, Field.Height));
                    foreach (Point Apple in Game.Apples)
                {
                    if (showApples)
                    {
                        g.FillEllipse(AppleBrush, new Rectangle(Apple.X - SnakeGame.AppleSize / 2, Apple.Y - SnakeGame.AppleSize / 2,
                                                                     SnakeGame.AppleSize, SnakeGame.AppleSize));
                    }
                }
                    foreach (LineSeg Obstacle in Game.Obstacles)
                        g.DrawLine(PenForObstacles, new System.Drawing.Point(Obstacle.Start.X, Obstacle.Start.Y)
                            , new System.Drawing.Point(Obstacle.End.X, Obstacle.End.Y));
                    foreach (LineSeg Body in Game.SnakeBody)
                        g.DrawLine(PenForSnake, new System.Drawing.Point((int)Body.Start.X, (int)Body.Start.Y)
                            , new System.Drawing.Point((int)Body.End.X, (int)Body.End.Y));               
            }
        }


        private void Snakes_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    Game.Move(Step, Direction.UP);
                    break;
                case Keys.Down:
                    Game.Move(Step, Direction.DOWN);
                    break;
                case Keys.Left:
                    Game.Move(Step, Direction.LEFT);
                    break;
                case Keys.Right:
                    Game.Move(Step, Direction.RIGHT);
                    break;
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void Field_Click(object sender, EventArgs e)
        {
            if (mainTimer.Enabled)
            {
                mainTimer.Stop();
            }
            else
            {
                mainTimer.Start();
            }

            Field.Refresh();
        }
    }
}
