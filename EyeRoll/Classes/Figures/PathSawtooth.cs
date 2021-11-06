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
        private int velY = 0, velX = 0, dir = 1;

        public override void Drop()
        {
            velX = 0;
            velY = 0;
            dir = 1;
        }

        public override Point Update(int speed)
        {
            int VS = 300;

            if (Direction == "Horizontal")
            {
                velX += 4 * speed;
                velY += 4 * dir * speed;
                int y = velY + init_position.Y;

                if (Math.Abs(velY) > VS)
                {
                    dir = -dir;
                }
                if (velX > init_position.X * 2)
                {
                    velX = 0;
                }
                return new Point(velX, y);
            }
            else
            {
                VS = 100;

                velX += 4 * speed;
                velY += 4 * dir * speed;
                int y = velY + init_position.X;

                if (Math.Abs(velY) > VS)
                {
                    dir = -dir;
                }
                if (velX > init_position.Y * 2)
                {
                    velX = 0;
                }
                return new Point(y, velX);
            }
        }
    }
}
