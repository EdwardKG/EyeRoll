using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeRoll.Classes.Figures
{
    class PathTriangle : Path
    {
        private int index = 0, timer = 0, velY = 0, velX = 0;

        public override void Drop()
        {
            index = 0;
            timer = 0;
            velY = 0;
            velX = 0;
        }

        public override Point Update(int speed)
        {
            timer += speed;

            if (index == 0)
            {
                velX += 4 * speed;
                velY += 4 * speed;
            }
            else if (index == 1)
            {
                velX += 4 * speed;
                velY -= 4 * speed;
            }
            else if (index == 2)
            {
                velX -= 4 * speed;
            }

            if (timer > 200 && index == 2) Drop();
            else if (timer > 100 && index != 2)
            {
                index++;
                timer = 0;
            }

            int x = velX + init_position.X - 400;
            int y = velY + init_position.Y - 200;

            return new Point(x, y);
        }
    }
}
