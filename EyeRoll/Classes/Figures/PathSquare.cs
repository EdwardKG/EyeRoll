using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeRoll.Classes.Figures
{
    class PathSquare : Path
    {
        private int velY = 0, velX = 0, timer = 0, index = 0;

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

            switch (index)
            {
                case 0:
                    velX += 4 * speed;
                    break;
                case 1:
                    velY += 4 * speed;
                    break;
                case 2:
                    velX -= 4 * speed;
                    break;
                case 3:
                    velY -= 4 * speed;
                    break;
            }

            if (timer > 100)
            {
                timer = 0;
                index = (index + 1) % 4;
            }

            int x = velX + init_position.X - 250;
            int y = velY + init_position.Y - 250;

            return new Point(x, y);
        }
    }
}
