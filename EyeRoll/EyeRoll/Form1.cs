using System;
using System.Drawing;
using System.Windows.Forms;

namespace EyeRoll
{
    public partial class MainWindow : Form
    {

        private float angle = 0;
        private int dir = 1;
        private int velY = 0;
        private int velX = 0;

        private float Smoothig = 0.05f;

        Color CurrentColor = Color.FromArgb(204, 0, 0);

        private int TrIndex = 0;
        private int TrTimer = 0;
        private int SqTimer = 0;
        private int SqIndex = 0;

        int Time = 0;

        Random rnd = new Random();

        public MainWindow()
        {
            InitializeComponent();
            GetCircly();
        }

        private void CycleTimer_Tick(object sender, EventArgs e)
        {
            
            Ball.Size = new Size(5 * Convert.ToInt32(Size.Text), 5 * Convert.ToInt32(Size.Text));


            switch (MoveType.Text)
            {
                case "smooth":
                    Smoothig = 0.05f;
                    break;
                case "step":
                    Smoothig = 1;
                    break;
            }


            switch (Movement.Text)
            {
                case "Eight":
                    Eight();
                    break;
                case "Circle":
                    Circle();
                    break;
                case "Infinity":
                    Infinity();
                    break;
                case "Sawtooth":
                    Sawtooth();
                    break;
                case "Sin":
                    Sin();
                    break;
                case "Ellipse":
                    Ellipse();
                    break;
                case "Triangle":
                    Triangle();
                    break;
                case "Square":
                    Square();
                    break;
                case "Random":

                    string[] states = new string[] { "Eight", "Circle", "Infinity", "Sawtooth", "Sin", "Ellipse", "Triangle", "Square" };

                    Movement.Text = states[rnd.Next(states.Length - 1)];
                    break;
            }
        }

        private void Circle()
        {
            int HS = 300, VS = 300; // ширина и высота восьмерка

            int x = (int)(HS * Math.Cos(angle) + (this.ClientRectangle.Width / 2));
            int y = (int)(VS * Math.Sin(angle) + (this.ClientRectangle.Height / 2));

            angle = angle + Smoothig * Convert.ToInt32(Speed.Text);
            Ball.Location = new Point(x, y);
        }

        private void Eight()
        {
            int HS = 150, VS = 300; // ширина и высота восьмерка

            int x = (int)(HS * Math.Cos(Math.PI / 2 + angle * 2) + (Width / 2));
            int y = (int)(VS * Math.Sin(angle) + (Height / 2));

            angle = angle + Smoothig * Convert.ToInt32(Speed.Text);
            Ball.Location = new Point(x, y);
        }

        private void Infinity()
        {
            int HS = 150, VS = 300; // ширина и высота

            int x = (int)(VS * Math.Sin(angle) + (Width / 2));
            int y = (int)(HS * Math.Cos(Math.PI / 2 + angle * 2) + (Height / 2));

            angle = angle + Smoothig * Convert.ToInt32(Speed.Text);
            Ball.Location = new Point(x, y);
        }

        private void Sawtooth()
        {
            int VS = 300;

            if (Direction.Text == "Horizontal")
            {
                velX += 4 * Convert.ToInt32(Speed.Text);
                velY += 4 * dir * Convert.ToInt32(Speed.Text);
                int y = velY + Height / 2;

                if (Math.Abs(velY) > VS)
                {
                    dir = -dir;
                }
                if (velX > Width)
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
                int y = velY + Width / 2;

                if (Math.Abs(velY) > VS)
                {
                    dir = -dir;
                }
                if (velX > Height)
                {
                    velX = 0;
                }
                Ball.Location = new Point(y, velX);
            }

            
        }

        private void Sin()
        {
            if (Direction.Text == "Horizontal")
            {
                int VS = 300; // ширина и высота

                velX += 4 * Convert.ToInt32(Speed.Text);
                int y = (int)(VS * Math.Sin(angle) + (Height / 2));

                angle = angle + 0.1f * Convert.ToInt32(Speed.Text);
                if (velX > Width)
                {
                    velX = 0; 
                }
                Ball.Location = new Point(velX, y);
            }
            else
            {
                int VS = 300; // ширина и высота

                velX += 4 * Convert.ToInt32(Speed.Text);
                int y = (int)(VS * Math.Sin(angle) + (Width / 2));

                angle = angle + 0.1f * Convert.ToInt32(Speed.Text);
                if (velX > Height)
                {
                    velX = 0;
                }
                Ball.Location = new Point(y, velX);
            }
            
            
        }

        private void Ellipse()
        {
            int HS = 600, VS = 300; // ширина и высота восьмерка

            int x = (int)(HS * Math.Cos(angle) + (this.ClientRectangle.Width / 2));
            int y = (int)(VS * Math.Sin(angle) + (this.ClientRectangle.Height / 2));

            angle = angle + Smoothig * Convert.ToInt32(Speed.Text);
            Ball.Location = new Point(x, y);
        }

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

            int x = velX + Width / 2 - 4 * 100;
            int y = velY + Height / 2 - 200;

            Ball.Location = new Point(x, y);
        }

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

            int x = velX + Width / 2 - 200;
            int y = velY + Height / 2 - 200;


            Ball.Location = new Point(x, y);
        }

        private void VisibleButton_Click(object sender, EventArgs e)
        {
            Tools.Visible = !Tools.Visible;
        }

        private void RedButton_Click(object sender, EventArgs e)
        {
            Ball.BackColor = RedButton.BackColor;
        }

        private void BlueButton_Click(object sender, EventArgs e)
        {
            Ball.BackColor = BlueButton.BackColor;
        }

        private void GreenButton_Click(object sender, EventArgs e)
        {
            Ball.BackColor = GreenButton.BackColor;
        }

        private void BackColor1_Click(object sender, EventArgs e)
        {
            BackColor = BackColor1.BackColor;
            Tools.BackColor = BackColor1.BackColor;
        }

        private void BackColor2_Click(object sender, EventArgs e)
        {
            BackColor = BackColor2.BackColor;
            Tools.BackColor = BackColor2.BackColor;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BackColor = button4.BackColor;
            Tools.BackColor = button4.BackColor;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            CycleTimer.Enabled = true;
            StopTimer.Interval = 60000 * Convert.ToInt32(UserTimer.Text);
            StopTimer.Enabled = true;
            SecTimer.Enabled = true;
            GetCircly();

        }

        private void StopTimer_Tick(object sender, EventArgs e)
        {
            StopTimer.Enabled = false;
            CycleTimer.Enabled = false;
        }

        private void GetCircly()
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, 5 * Convert.ToInt32(Size.Text), 5 * Convert.ToInt32(Size.Text));
            Region rgn = new Region(path);
            Ball.Region = rgn;
            Ball.BackColor = CurrentColor;
        }

        private void Size_SelectedItemChanged(object sender, EventArgs e)
        {
            GetCircly();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            StopTimer.Enabled = false;
            CycleTimer.Enabled = false;
            SecTimer.Enabled = false;
            Time = 0;
        }

        private void SecTimer_Tick(object sender, EventArgs e)
        {
            Time++;
            
            Timer.Text = "Time: " + Time.ToString();
        }
    }
}
