using System;
using System.Drawing;
using EyeRoll.Classes.Fields_Inherit;

namespace EyeRoll.Classes.Figures
{

    class PathTriangle : Path, IDirectionPath
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
            int lengthOfSide = 100;
            int startX = 400;
            int startY = 200;
            int res = 1156 / 681;
            int coefX = 1156 / Width;
            int coefY = 681 / Height;

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

            if (Width / Height < res)
            {
                if (Width > Height)
                {
                    lengthOfSide /= coefY;
                    startX /= coefY;
                    startY /= coefY;

                }
                else if (Height > Width)
                {
                    lengthOfSide /= coefX;
                    startX /= coefX;
                    startY /= coefX;
                }

            }

            //681 1156

            else if (Width / Height > res)
            {
                if (Width > Height)
                {
                    lengthOfSide *= coefY;
                    startX *= coefY;
                    startY *= coefY;
                }
                else if (Height > Width)
                {
                    lengthOfSide *= coefX;
                    startX *= coefX;
                    startY *= coefX;
                }
            }


            if (timer > lengthOfSide * 2 && index == 2) Drop();
            else if (timer > lengthOfSide && index != 2)
            {
                index++;
                timer = 0;
            }
            Console.WriteLine(lengthOfSide);

            int x = velX + init_position.X - startX;
            int y = velY + init_position.Y - startY;

            return new Point(x, y);
        }
    }
}
