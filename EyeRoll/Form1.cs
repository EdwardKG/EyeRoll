using EyeRoll.Classes;
using EyeRoll.Classes.Fields_Inherit;
using EyeRoll.Classes.Figures;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using static EyeRoll.Classes.PathTypes;

namespace EyeRoll
{
    public partial class MainWindow : Form
    {
        private int simulationTime = 0;
        private Path PathFigure;
        private string mm_width, mm_height;
        private decimal delay;
        Point GetCenter() => new Point(Width / 2 - 10, Height / 2 - 20);

        // init

        public MainWindow() => InitializeComponent();
        private void MainWindow_Load(object sender, EventArgs e)
        {
            Enum.GetValues(typeof(PathTypes)).Cast<PathTypes>().ToList().ForEach(x => Movement.Items.Add(x));
            Movement.SelectedIndexChanged += (s, args) => InitPath();

            TopMost = true;
            WindowState = FormWindowState.Maximized;
            DrawCirclePen();


            void changeSize(object s, EventArgs args, int tb)
            {
                var mm = (s as TextBox).Text;
                if (!double.TryParse(mm, out var num))
                {
                    switch (tb)
                    {
                        case 1:
                            (s as TextBox).Text = mm_width;
                            return;

                        case 2:
                            (s as TextBox).Text = mm_height;
                            return;

                    }
                }

                /* var top_boundary = tb == 1 ? 406 : 211;
                 var bottom_boundary = 50;

                if (num > top_boundary)
                {
                    num = top_boundary;
                    (s as TextBox).Text = $"{num}";
                }
                else if (num > bottom_boundary)
                {
                    num = bottom_boundary;
                    (s as TextBox).Text = $"{num}";
                }*/

                var px = (int)Math.Round(num * 96.0 / 25.4);
                switch (tb)
                {
                    case 1:
                        pictureBox1.Width = px;
                        mm_width = mm;
                        break;
                    case 2:
                        pictureBox1.Height = px;
                        mm_height = mm;
                        break;
                }

                PathFigure.init_position = GetCenter();
            };

            pictureBox1.Location = new Point(GetCenter().X - pictureBox1.Width / 2, GetCenter().Y - pictureBox1.Height / 2);
            Ball.Location = GetCenter();


            Width_TextBox.Text = "247";  //406
            Height_TextBox.Text = "180"; //211
/*
            Width_TextBox.KeyDown += (s, args) => changeSize(s, args, 1); // { if (args.KeyCode is Keys.Enter)..}
            Height_TextBox.KeyDown += (s, args) => changeSize(s, args, 2); //{ if (args.KeyCode is Keys.Enter) ..}

            pictureBox1.Location = new Point(GetCenter().X - pictureBox1.Width / 2, GetCenter().Y - pictureBox1.Height / 2);
            Ball.Location = GetCenter();*/

            Width_TextBox.KeyDown += (s, args) =>
            {
                changeSize(s, args, 1);
                pictureBox1.Location = new Point(GetCenter().X - pictureBox1.Width / 2, GetCenter().Y - pictureBox1.Height / 2);

            };// { if (args.KeyCode is Keys.Enter)..}

            Height_TextBox.KeyDown += (s, args) =>
            {
                changeSize(s, args, 2); //{ if (args.KeyCode is Keys.Enter) ..}
                pictureBox1.Location = new Point(GetCenter().X - pictureBox1.Width / 2, GetCenter().Y - pictureBox1.Height / 2);
            };

            Movement.SelectedItem = Circle;
        }

        // simulation

        private void StartSimulation()
        {
            PathFigure.Drop();
            UpdateTimer.Enabled = true;
            SecTimer.Enabled = true;
            DrawCirclePen();
            UserUpDownTimer.Enabled = false;
        }
        private void StopSimulation()
        {
            UpdateTimer.Enabled = false;
            SecTimer.Enabled = false;
            simulationTime = 0;
            UserUpDownTimer.Enabled = true;
        }

        readonly Random rnd = new Random();
        private void InitPath()
        {
            var center = GetCenter();
            WhichFigureShouldDraw(Movement.SelectedItem as PathTypes?);
            

            PathFigure.init_position = center;
            Direction.Enabled = PathFigure is IDirectionPath;
            MoveType.Enabled = PathFigure is ISmoothingPath;
            pictureBox1.Enabled = PathFigure is ILocationBox;
            Ball.Enabled = Ball is IBallCoordinates;

            if (PathFigure is IDirectionPath path_)
            {
                path_.Direction = Direction.Text;
                path_.Width = pictureBox1.Width;
                path_.Height = pictureBox1.Height;
            }

            if (PathFigure is ILocationBox location_)
            {
                location_.LocationX = pictureBox1.Location.X;
                location_.LocationY = pictureBox1.Location.Y;
            }
            if (Ball is IBallCoordinates ballCoordinates_)
            {
                ballCoordinates_.Top = Ball.Top;
                ballCoordinates_.Left = Ball.Left;
            }
            PathFigure.Drop();
        }

        // timers tick

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            if (PathFigure is ISmoothingPath path)
            {
                switch (MoveType.Text)
                {
                    case "smooth":
                        path.Smoothing = 0.05f;
                        UpdateTimer.Interval = 20;
                        break;
                    case "step":
                        path.Smoothing = 0.05f;
                        delay = Step_delay.Value * 1000;
                        UpdateTimer.Interval = (int)delay;
                        break;
                }
            }
            if (PathFigure is IDirectionPath path_)
            {
                path_.Direction = Direction.Text;
                path_.Width = pictureBox1.Width;
                path_.Height = pictureBox1.Height;
            }

            if (!int.TryParse(Speed.Text, out int speed)) speed = 1;
            else if (speed < 1) speed = 1;
            else if (speed > 3) speed = 3;
            Speed.Text = speed.ToString();

            Ball.Location = PathFigure.Update(speed);
        }
        private void SecTimer_Tick(object sender, EventArgs e)
        {
            Timer.Text = "Time: " + (++simulationTime).ToString();
            if (simulationTime >= int.Parse(UserUpDownTimer.Text)) StopSimulation();
        }

        // render

        readonly Color CurrentColor = Color.FromArgb(204, 0, 0);
        private void DrawCirclePen()
        {
            if (!int.TryParse(Size.Text, out int size))
            {
                Size.Text = (Ball.Size.Height / 5).ToString();
                return;
            }
            if (size <= 0 || size > 10)
            {
                Size.Text = (Ball.Size.Height / 5).ToString();
                return;
            }

            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, 5 * size, 5 * size);
            Region rgn = new Region(path);
            Ball.Region = rgn;
            Ball.BackColor = CurrentColor;
            Ball.Size = new Size(size * 5, size * 5);
        }


        // click events & design

        private void Size_SelectedItemChanged(object sender, EventArgs e) => DrawCirclePen();
        private void Start_Click(object sender, EventArgs e) => StartSimulation();
        private void StopButton_Click(object sender, EventArgs e) => StopSimulation();

        private void VisibleButton_Click(object sender, EventArgs e) => Tools.Visible = !Tools.Visible;
        private void ForegroundColorButtonClick(object sender, EventArgs e) => Ball.BackColor = (sender as Button).BackColor;

        private void TypeChanged(object sender, EventArgs e)
        {
            var temp = (sender as ComboBox);
            switch (temp.Text)
            {
                case "smooth":
                    label3.Text = "Speed of movement";
                    Step_delay.Visible = false;
                    Speed.Visible = true;
                    break;
                case "step":
                    label3.Text = "Step delay, seconds";
                    Step_delay.Visible = true;
                    Speed.Visible = false;
                    break;
            }
        }

        private void IsTypeChanged(object sender, EventArgs e)
        {
            if (Movement.SelectedItem as PathTypes? == PathTypes.Hopping_dot)
            {
                MoveType.Text = "step";
                MoveType.Items.Remove("smooth");
            } 
            else if (!MoveType.Items.Contains("smooth")) MoveType.Items.Add("smooth");
        }

        private void BackgroundColorButtonClick(object sender, EventArgs e)
        {
            BackColor = (sender as Button).BackColor;
            Tools.BackColor = (sender as Button).BackColor;
        }

        private void WhichFigureShouldDraw(PathTypes? val) {
            switch (val)
            {
                case Eight:
                    PathFigure = new PathEight();
                    break;
                case Circle:
                    PathFigure = new PathCircle();
                    break;
                case Infinity:
                    PathFigure = new PathInfinity();
                    break;
                case Ellipse:
                    PathFigure = new PathEllipse();
                    break;
                case Triangle:
                    PathFigure = new PathTriangle();
                    break;
                case Square:
                    PathFigure = new PathSquare();
                    break;
                case Hopping_dot:
                    PathFigure = new PathHoppingDot();
                    break;
                case Line:
                    PathFigure = new PathLine();
                    break;
                case Diagonal:
                    PathFigure = new PathDiagonal();
                    break;
                case Ping_pong:
                    PathFigure = new PathPing_pong();
                    break;
                case PathTypes.Random:
                    /*Movement.SelectedItem = PathTypes.Random;*/
/*                    while (SecTimer.Enabled)
                    {*/
                        /*times = randomQuantity.Next(1, 5);*/
                    var randomFigure = Movement.Items[rnd.Next(0, Movement.Items.Count - 2)];
                        /*Movement.SelectedItem =*/
                        for (int i = 0; i < 5; i++)
                        {
                            WhichFigureShouldDraw(randomFigure as PathTypes?);
                        }
                    /*}*/
                    /*                    */
                   /* InitPath();*/
                    break;
                default:
                    InitPath();
                    return;
            }

        }
    }
}
