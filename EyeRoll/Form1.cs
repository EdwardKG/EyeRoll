using EyeRoll.Classes;
using EyeRoll.Classes.Figures;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.ComboBox;

namespace EyeRoll
{
    public partial class MainWindow : Form
    {
        readonly Random rnd = new Random();
        int Time = 0;
        Path pathFigure;

        // init

        public MainWindow() => InitializeComponent();
        private void MainWindow_Load(object sender, EventArgs e)
        {
            Enum.GetValues(typeof(PathTypes)).Cast<PathTypes>().ToList().ForEach(x => Movement.Items.Add(x));
            DrawCirclePen();
        }

        // simulation & drawing

        private void StartSimulation()
        {
            DrawTimer.Enabled = true;
            SecTimer.Enabled = true;
            DrawCirclePen();
            UserTimer.Enabled = false;
        }
        private void StopSimulation()
        {
            DrawTimer.Enabled = false;
            SecTimer.Enabled = false;
            Time = 0;
            UserTimer.Enabled = true;
        }

        Color CurrentColor = Color.FromArgb(204, 0, 0); 
        private void DrawCirclePen()
        {
            if (string.IsNullOrEmpty(Size.Text)) return;
            int size = Convert.ToInt32(Size.Text);
            if (size <= 0 || size > 3) return;

            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, 5 * size, 5 * size);
            Region rgn = new Region(path);
            Ball.Region = rgn;
            Ball.BackColor = CurrentColor;
        }

        // timers tick

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            
            Ball.Size = new Size(5 * Convert.ToInt32(Size.Text), 5 * Convert.ToInt32(Size.Text));


            switch (MoveType.Text)
            {
                case "smooth":
                    Smoothing = 0.05f;
                    break;
                case "step":
                    Smoothing = 1;
                    break;
            }

            var center = new Point(pictureBox1.Width / 2, pictureBox1.Height / 2);
            switch (Movement.Text)
            {
                case "Eight":
                    pathFigure = new PathEight(center);
                    break;
                case "Circle":
                    pathFigure = new PathCircle(center);
                    break;
                case "Infinity":
                    pathFigure = new PathInfinity(center);
                    break;
                case "Sawtooth":
                    pathFigure = new PathSawtooth(center);
                    break;
                case "Sin":
                    pathFigure = new PathSin(center);
                    break;
                case "Ellipse":
                    pathFigure = new PathEllipse(center);
                    break;
                case "Triangle":
                    pathFigure = new PathTriangle(center);
                    break;
                case "Square":
                    pathFigure = new PathSquare(center);
                    break;
                case "Random":
                    string[] states = new string[] { "Eight", "Circle", "Infinity", "Sawtooth", "Sin", "Ellipse", "Triangle", "Square" };                      
                    Movement.Text = states[rnd.Next(states.Length - 1)];
                    break;
            }
        }
        private void SecTimer_Tick(object sender, EventArgs e)
        {
            Timer.Text = "Time: " + (++Time).ToString();
            if (Time >= int.Parse(UserTimer.Text) * 60) StopSimulation();
        }

        // traectory methods
        private float angle = 0;
        private int velY = 0;
        private int velX = 0;
        private int dir = 1;
        private float Smoothing = 0.05f;
        private void Sawtooth()
        {
            int VS = 300;

            if (Direction.Text == "Horizontal")
            {
                velX += 4 * Convert.ToInt32(Speed.Text);
                velY += 4 * dir * Convert.ToInt32(Speed.Text);
                int y = velY + pictureBox1.Height / 2;

                if (Math.Abs(velY) > VS)
                {
                    dir = -dir;
                }
                if (velX > pictureBox1.Width)
                {
                    velX = 0;
                }
                Ball.Location = new Point(velX, y);
            }
            else
            {

                VS = 100;

                velX += 4 * Convert.ToInt32(Speed.Text);
                velY += 4 * dir * Convert.ToInt32(Speed.Text);
                int y = velY + pictureBox1.Width / 2;

                if (Math.Abs(velY) > VS)
                {
                    dir = -dir;
                }
                if (velX > pictureBox1.Height)
                {
                    velX = 0;
                }
                Ball.Location = new Point(y, velX);
            }

            
        }


        private int TrIndex = 0;
        private int TrTimer = 0;
        private void Triangle()
        {
            Speed.Text = "1";
            TrTimer++;

            if (TrIndex == 0)
            {

                velX += 4 * Convert.ToInt32(Speed.Text);
                velY += 4 * Convert.ToInt32(Speed.Text);

            }
            else if (TrIndex == 1)
            {
                velX += 4 * Convert.ToInt32(Speed.Text);
                velY -= 4 * Convert.ToInt32(Speed.Text);
            }
            else if (TrIndex == 2)
            {
                velX -=  4 * Convert.ToInt32(Speed.Text); 
            }

            if (TrTimer > 200 && TrIndex == 2)
            {
                TrIndex = 0;
                TrTimer = 0;
            }
            else if (TrTimer > 100 && TrIndex != 2)
            {
                TrIndex++;
                TrTimer = 0;
            }

            int x = velX + pictureBox1.Width / 2 - 400;
            int y = velY + pictureBox1.Height / 2 - 200;

            Ball.Location = new Point(x, y);
        }

        private int SqTimer = 0;
        private int SqIndex = 0; 
        private void Square()
        {

            Speed.Text = "1";

            SqTimer++;
            switch (SqIndex)
            {
                case 0:
                    velX += 4 * Convert.ToInt32(Speed.Text);
                    break;
                case 1:
                    velY += 4 * Convert.ToInt32(Speed.Text);
                    break;
                case 2:
                    velX -= 4 * Convert.ToInt32(Speed.Text);
                    break;
                case 3:
                    velY -= 4 * Convert.ToInt32(Speed.Text);
                    break;
            }

            if (SqTimer > 100)
            {
                SqTimer = 0;
                SqIndex = (SqIndex + 1) % 4;
            }

            int x = velX + pictureBox1.Width / 2 - 200;
            int y = velY + pictureBox1.Height / 2 - 200;


            Ball.Location = new Point(x, y);
        } 

        // click events & design

        private void Size_SelectedItemChanged(object sender, EventArgs e) => DrawCirclePen();
        private void Start_Click(object sender, EventArgs e) => StartSimulation();
        private void StopButton_Click(object sender, EventArgs e) => StopSimulation();

        private void VisibleButton_Click(object sender, EventArgs e) => Tools.Visible = !Tools.Visible;
        private void ForegroundColorButtonClick(object sender, EventArgs e) => Ball.BackColor = (sender as Button).BackColor;
        private void BackgroundColorButtonClick(object sender, EventArgs e)
        {
            BackColor = (sender as Button).BackColor;
            Tools.BackColor = (sender as Button).BackColor;
        }
    }
}
