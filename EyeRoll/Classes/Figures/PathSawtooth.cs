using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeRoll.Classes.Figures
{
    class PathSawtooth : Path
    {
        private string direction { get; set; }
        private float angle = 0;
        private float smoothing = 0.05f;

        public PathSawtooth(Point init_position) : base(init_position)
        {
            this.direction = direction;
        }

        public override void Drop()
        {
            angle = 0;
            vel = 0;

        }

        public override Point Update(int speed)
        {
            int VS = 300;

            if (direction == "Horizontal")
            {
                velX += 4 * speed;
                velY += 4 * dir * speed;
                int y = velY + init_position.Y / 2;

                if (Math.Abs(velY) > VS)
                {
                    dir = -dir;
                }
                if (velX > init_position.X)
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
                int y = velY + init_position.X / 2;

                if (Math.Abs(velY) > VS)
                {
                    dir = -dir;
                }
                if (velX > init_position.Y)
                {
                    velX = 0;
                }
                return new Point(y, velX);
            }
    }
}
