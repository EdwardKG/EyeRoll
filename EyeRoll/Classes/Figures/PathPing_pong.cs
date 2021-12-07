using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EyeRoll.Classes.Fields_Inherit;

namespace EyeRoll.Classes.Figures
{
    class PathPing_pong : Path, IDirectionPath, ISmoothingPath, IBallCoordinates, ILocationBox
    {
        public string Direction { get; set; }
        public float Smoothing { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Top { get; set; }
        public int Left { get; set; }
        public int LocationX { get; set; }
        public int LocationY { get; set; }

        private int velY, velX;



        public override void Drop()
        {
            velX = 3;
            velY = 3;
            Left = 300;
            Top = 300;
        }

        public override Point Update(int speed)
        {
            Width = init_position.X - 5 + Width / 2;
            Height = init_position.Y - 5 + Height / 2;
            int negativeHeight = init_position.Y + 35 - Height / 2;
            // After collision with boundaries
            if (Left > Width || Left <= LocationX)
            {
                velX *= -1;       // negative changes direction
            }

            if (Top <= negativeHeight)
            {
                velY *= 1;
                velY += 2;
            }
            else if (Top > Height)
            {
                velY *= -1;
            }



            if (Top > Height) Top = Height;

            Left += velX;
            Top += velY;

            return new Point(Left, Top);
            }
        }
    }
