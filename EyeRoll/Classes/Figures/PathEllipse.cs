using EyeRoll.Classes.Fields_Inherit;
using System;
using System.Drawing;

namespace EyeRoll.Classes.Figures
{
    class PathEllipse : Path, ISmoothingPath, IDirectionPath
    {
        private float angle = 0;
        public float Smoothing { get; set; }
        public int Height { get; set; }
        public string Direction { get; set; }
        public int Width { get; set; }

        private int velY, velX;

        public override void Drop()
        {
            angle = -1.5f;
            velX = init_position.X;
            velY = init_position.Y;
        }

        public override Point Update(int speed)
        {
            int size = (Height + Width) / 6;
            int HS = size, VS = size / 2;

            if (Height / Width > 2)
            {
                size /= 3;
                HS = size;
                VS = HS * 2;
            }
            if (Width / Height > 2)
            {
                size /= 3;
                HS = size;
                VS = HS / 2;
            }

            int x = (int)(HS * Math.Cos(angle) + velX);
            int y = (int)(VS * Math.Sin(angle) + velY);

            angle += Smoothing * speed;
            return new Point(x, y);
        }
    }
}
