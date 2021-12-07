using System;
using System.Drawing;
using EyeRoll.Classes.Fields_Inherit;

namespace EyeRoll.Classes.Figures
{

    class PathDiagonal : Path, IDirectionPath, ISmoothingPath
    {
        private int index = 2, timer = 0;
        public float Smoothing { get; set; }
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
            int startX = 200;
            int startY = 200;
            int lengthOfSide = 100;
            /*int res = 1156 / 681;*/
            int coefX = 1156 / Width;
            int coefY = 681 / Height;

            timer += speed;


            if (Direction == "Horizontal")
            { 
                if (index == 0)
                {
                    velX += 4 * speed;
                    velY += 4 * speed;
                    
                }
                else if (index == 1)
                {
                    velX -= 4 * speed;
                    velY -= 4 * speed;

                }

            }
            else
            {
                startY = 200;
                startX = -225;
                if (index == 0)
                {
                    velX -= 4 * speed;
                    velY += 4 * speed;
                }
                else if (index == 1)
                {
                    velX += 4 * speed;
                    velY -= 4 * speed;
                }
            }
            
/*            }

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

            }*/

            //681 1156

/*            else if (Width / Height > res)
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
            }*/


            if (timer > lengthOfSide && index == 1) Drop();
            else if (timer > lengthOfSide && index != 1)
            {
                index++;
                timer = 0;
            }

            int x = velX + init_position.X - startX;
            int y = velY + init_position.Y - startY;

            return new Point(x, y);
        }
    }
}
