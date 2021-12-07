using System.Drawing;
using EyeRoll.Classes.Fields_Inherit;

namespace EyeRoll.Classes.Figures
{
    class PathLine : Path, IDirectionPath, ISmoothingPath, ILocationBox
    {
        private int index = 0, timer = 0;
        public string Direction { get; set; }
        public float Smoothing { get; set; }
        public int LocationX { get; set; }
        public int LocationY { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        private int velY, velX;

        public override void Drop()
        {
            index = 0;
            timer = 0;
            velY = LocationY-50;
            velX = LocationX+150;
        }

        public override Point Update(int speed)
        {
            timer += speed;

            if (Direction == "Horizontal")
            {
                switch (index)
                {
                    case 0:
                        velX += 4 * speed;
                        break;
                    case 1:
                        velX -= 4 * speed;
                        break;
                }
            }
            else
            {
                switch (index)
                {
                    case 0:
                        velY += 4 * speed;
                        break;
                    case 1:
                        velY -= 4 * speed;
                        break;
                }
            }
            if (timer > 200)
            {
                timer = 0;
                index = (index + 1) % 2;
            }

            int x = 0;
            int y = 0;
            switch (Direction)
            {
                case "Vertical":
                    y = velY;
                    x = init_position.X;
                    break;
                case "Horizontal":
                    x = velX;
                    y = init_position.Y;
                    break;
            }
            return new Point(x, y);
        }
    }
}
