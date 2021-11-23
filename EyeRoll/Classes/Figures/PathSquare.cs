using System.Drawing;
using EyeRoll.Classes.Fields_Inherit;

namespace EyeRoll.Classes.Figures
{
    class PathSquare : Path, IDirectionPath
    {
        private int index = 0, timer = 0;
        public string Direction { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        private int velY, velX;

        public override void Drop()
        {
            index = 0;
            timer = 0;
            velY = 0;
            velX = 0;
        }

        public override Point Update(int speed)
        {
            int lengthOfSide = 100; // if to x2 = startPoint of drawing
            int res = 1156 / 681;
            int coefX = 1156 / Width;
            int coefY = 681 / Height;

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

            if (Width / Height < res)
            {
                if (Width > Height)
                    lengthOfSide /= coefY;
                else if (Height > Width)
                    lengthOfSide /= coefX;
            }

            else if (Width / Height > res)
            {
                if (Width > Height)
                    lengthOfSide *= coefY;
                else if (Height > Width)
                    lengthOfSide *= coefX;
            }

            if (timer > lengthOfSide)
            {
                timer = 0;
                index = (index + 1) % 4;
            }



            int x = velX + init_position.X - lengthOfSide * 2;
            int y = velY + init_position.Y - lengthOfSide * 2;

            return new Point(x, y);
        }
    }
}
