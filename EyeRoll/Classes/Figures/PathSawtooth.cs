using EyeRoll.Classes.Fields_Inherit;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeRoll.Classes.Figures
{
    class PathSawtooth : Path, IDirectionPath
    {
        public string Direction { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        private int velY, velX, dir;

        public override void Drop()
        {
            velX = 0;
            velY = 0;
            if (Direction == "Horizontal") velX = init_position.X;
            else velY = init_position.Y;
            dir = 1;
        }

        public override Point Update(int speed)
        {
            int VS = Height / 2;

            if (Direction == "Horizontal")
            {
                velX += 4 * speed;
                velY += 4 * dir * speed;
                int y = velY + init_position.Y;

                if (Math.Abs(velY) > VS)
                {
                    dir = -dir;
                }
                if (velX > init_position.X + Width / 2)
                {
                    velX = init_position.X - Width / 2;
                }
                return new Point(velX, y);
            }
            else
            {
                VS = Width / 2;

                velX += 4 * speed;
                velY += 4 * dir * speed;
                int y = velY + init_position.X;

                if (Math.Abs(velY) > VS)
                {
                    dir = -dir;
                }
                if (velX > init_position.Y + Height / 2)
                {
                    velX = init_position.Y - Height / 2;
                }
                return new Point(y, velX);
            }
        }
    }
}
